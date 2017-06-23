using System;
using System.Collections.Generic;

using UIKit;

namespace SnapKit
{
    public sealed class Constraint
    {
        private ConstraintItem _to;
        private ConstraintItem _from;
        private ConstraintRelation _relation;
        private List<LayoutConstraint> _constraints;
        private ConstraintConstantTarget _constant;
        private ConstraintPriorityTarget _priority;
        private ConstraintMultiplierTarget _multiplier;

        internal string Label
        {
            get;
        }

        internal Tuple<string, uint> SourceLocation
        {
            get;
        }

        public LayoutConstraint[] LayoutConstraints
        {
            get
            {
                return _constraints.ToArray();
            }
        }

        public Constraint(ConstraintItem from, ConstraintItem to, ConstraintRelation relation, Tuple<string, uint> sourceLocation, ConstraintMultiplierTarget multiplier, ConstraintConstantTarget constant, ConstraintPriorityTarget priority, string label = null)
        {
            _to = to;
            _from = from;
            _relation = relation;
            _constant = constant;
            _priority = priority;
            _multiplier = multiplier;
            _constraints = new List<LayoutConstraint>();

            Label = label;
            SourceLocation = sourceLocation;

            var layoutFrom     = _from.LayoutConstraintItem;
            var layoutRelation = _relation.LayoutRelation();

            var layoutToAttributes   = _to.Attributes.LayoutAttributes();
            var layoutFromAttributes = _from.Attributes.LayoutAttributes();



            foreach (var layoutFromAttribute in layoutFromAttributes)
            {
                var layoutToAttribute = default(NSLayoutAttribute);

                if (layoutToAttributes?.Length > 0)
                {
                    if (_from.Attributes == ConstraintAttributes.Edges
                    &&  _to.Attributes   == ConstraintAttributes.Margins)
                    {
                        switch (layoutFromAttribute)
                        {
                            case NSLayoutAttribute.Top:
                                layoutToAttribute = NSLayoutAttribute.TopMargin;
                                break;
                            case NSLayoutAttribute.Left:
                                layoutToAttribute = NSLayoutAttribute.LeftMargin;
                                break;
                            case NSLayoutAttribute.Bottom:
                                layoutToAttribute = NSLayoutAttribute.BottomMargin;
                                break;
                            case NSLayoutAttribute.Right:
                                layoutToAttribute = NSLayoutAttribute.RightMargin;
                                break;
                            default:
                                throw new InvalidOperationException();
                        }
                    }

                    else if (_from.Attributes == ConstraintAttributes.Margins
                         &&  _to.Attributes   == ConstraintAttributes.Edges)
                    {
                        switch (layoutFromAttribute)
                        {
                            case NSLayoutAttribute.TopMargin:
                                layoutToAttribute = NSLayoutAttribute.Top;
                                break;
                            case NSLayoutAttribute.LeftMargin:
                                layoutToAttribute = NSLayoutAttribute.Left;
                                break;
                            case NSLayoutAttribute.BottomMargin:
                                layoutToAttribute = NSLayoutAttribute.Bottom;
                                break;
                            case NSLayoutAttribute.RightMargin:
                                layoutToAttribute = NSLayoutAttribute.Right;
                                break;
                            default:
                                throw new InvalidOperationException();
                        }
                    }

                    else if (_from.Attributes == _to.Attributes)
                    {
                        layoutToAttribute = layoutFromAttribute;
                    }

                    else
                    {
                        layoutToAttribute = layoutToAttributes[0];
                    }
                }

                else
                {
                    if (_to.Target == null && (layoutFromAttribute == NSLayoutAttribute.CenterX || layoutFromAttribute == NSLayoutAttribute.CenterY))
                    {
                        layoutToAttribute = ((layoutFromAttribute == NSLayoutAttribute.CenterX) ? NSLayoutAttribute.Left : NSLayoutAttribute.Top);
                    }

                    else
                    {
                        layoutToAttribute = layoutFromAttribute;
                    }
                }

                var layoutConstant = _constant.ValueForAttribute(layoutToAttribute);

                var layoutTo = _to.Target;

                if (layoutTo == null 
                &&  layoutToAttribute != NSLayoutAttribute.Width
                &&  layoutToAttribute != NSLayoutAttribute.Height)
                {
                    layoutTo = layoutFrom.Superview;
                }

                // Create layout constraint
                var layoutConstraint = new LayoutConstraint(
                    layoutFrom,
                    layoutFromAttribute,
                    layoutRelation,
                    (UIView) layoutTo,
                    layoutToAttribute,
                    _multiplier,
                    layoutConstant
                );

                // Set label
                layoutConstraint.Label = Label;

                // Set priority
                layoutConstraint.Priority = _priority;

                // Set constraint
                layoutConstraint.Constraint = this;

                // Append
                _constraints.Add(layoutConstraint);
            }
        }

        public void Activate()
        {
            ActivateIfNeeded();
        }

        public void Deactivate()
        {
            DeactivateIfNeeded();
        }

        public Constraint Update(ConstraintInsetTarget inset)
        {
            _constant = inset.TargetValue;
            return this;
        }

        public Constraint Update(ConstraintOffsetTarget offset)
        {
            _constant = offset;
            return this;
        }

        public Constraint Update(ConstraintPriorityTarget priority)
        {
            _priority = priority;
            return this;
        }

        internal void UpdateConstantAndPriorityIfNeeded()
        {
            foreach (var constraint in _constraints)
            {
                var attribute = (constraint.Value.SecondAttribute == NSLayoutAttribute.NoAttribute) ? constraint.Value.FirstAttribute : constraint.Value.SecondAttribute;

                constraint.Value.Constant = _constant.ValueForAttribute(attribute);

                var requiredPriority = UILayoutPriority.Required;

                if (constraint.Value.Priority < (float) requiredPriority && _priority != requiredPriority)
                {
                    constraint.Value.Priority = _priority;
                }
            }
        }

        internal void ActivateIfNeeded(bool updateExisting = false)
        {

        }

        internal void DeactivateIfNeeded()
        {

        }
    }
}
