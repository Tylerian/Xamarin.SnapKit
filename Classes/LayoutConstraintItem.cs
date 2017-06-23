using System;
using System.Collections.Generic;

using UIKit;

namespace SnapKit
{
    public class LayoutConstraintItem
    {
        private object _value;
        private List<Constraint> _constraints;

        internal UIView Value
        {
            get
            {
                return _value as UIView;
            }
        }

        internal UIView Superview
        {
            get
            {
                if (_value is UIView)
                {
                    return ((UIView) _value).Superview;
                }

                if (_value is ConstraintLayoutGuide)
                {
                    return ((ConstraintLayoutGuide)_value).Value.OwningView;
                }

                return null;
            }
        }

        internal Constraint[] Constraints
        {
            get
            {
                return _constraints.ToArray();
            }
        }

        private LayoutConstraintItem(UIView value)
        {
            _value = value;
        }

        private LayoutConstraintItem(ConstraintLayoutGuide value)
        {
            _value = value;
        }

        internal void Add(Constraint[] constraints)
        {
            _constraints.AddRange(constraints);
        }

        internal void Remove(Constraint[] constraints)
        {
            foreach (var constraint in constraints)
            {
                _constraints.Remove(constraint);
            }
        }

        internal void Prepare()
        {
            if (_value is UIView)
            {
                ((UIView)_value).TranslatesAutoresizingMaskIntoConstraints = false;
            }
        }

        public static implicit operator LayoutConstraintItem(UIView value)
        {
            return new LayoutConstraintItem(value);
        }

        public static implicit operator LayoutConstraintItem(ConstraintLayoutGuide value)
        {
            return new LayoutConstraintItem(value);
        }
    }
}
