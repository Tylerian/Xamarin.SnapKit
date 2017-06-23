using System;
using System.Collections.Generic;

namespace SnapKit
{
    public class ConstraintMaker
    {
        private LayoutConstraintItem _item;
        private List<ConstraintDescription> _descriptions;
        
        public ConstraintMakerExtendable Top
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Top);
            }
        }

        public ConstraintMakerExtendable Left
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Left);
            }
        }

        public ConstraintMakerExtendable Bottom
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Bottom);
            }
        }

        public ConstraintMakerExtendable Right
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Right);
            }
        }

        public ConstraintMakerExtendable Leading
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Leading);
            }
        }

        public ConstraintMakerExtendable Trailing
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Trailing);
            }
        }
        public ConstraintMakerExtendable Width
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Width);
            }
        }

        public ConstraintMakerExtendable Height
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Height);
            }
        }

        public ConstraintMakerExtendable CenterX
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.CenterX);
            }
        }

        public ConstraintMakerExtendable CenterY
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.CenterY);
            }
        }

        public ConstraintMakerExtendable Baseline
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.FirstBaseline);
            }
        }

        public ConstraintMakerExtendable LastBaseline
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.LastBaseline);
            }
        }

        public ConstraintMakerExtendable FirstBaseline
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.FirstBaseline);
            }
        }

        public ConstraintMakerExtendable TopMargin
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.TopMargin);
            }
        }

        public ConstraintMakerExtendable LeftMargin
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.LeftMargin);
            }
        }

        public ConstraintMakerExtendable RightMargin
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.RightMargin);
            }
        }

        public ConstraintMakerExtendable BottomMargin
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.BottomMargin);
            }
        }

        public ConstraintMakerExtendable LeadingMargin
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.LeadingMargin);
            }
        }

        public ConstraintMakerExtendable TrailingMargin
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.TrailingMargin);
            }
        }

        public ConstraintMakerExtendable CenterXWithinMargins
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.CenterXWithinMargins);
            }
        }

        public ConstraintMakerExtendable CenterYWithinMargins
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.CenterYWithinMargins);
            }
        }

        public ConstraintMakerExtendable Edges
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Edges);
            }
        }

        public ConstraintMakerExtendable Size
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Size);
            }
        }

        public ConstraintMakerExtendable Center
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Center);
            }
        }

        public ConstraintMakerExtendable Margins
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.Margins);
            }
        }

        public ConstraintMakerExtendable CenterWithinMargins
        {
            get
            {
                return MakeExtendableWithAttributes(ConstraintAttributes.CenterWithinMargins);
            }
        }

        public ConstraintMaker(LayoutConstraintItem item)
        {
            _item = item;
            _item.Prepare();

            _descriptions = new List<ConstraintDescription>();
        }

        public ConstraintMakerExtendable MakeExtendableWithAttributes(ConstraintAttributes attributes)
        {
            var description = new ConstraintDescription(_item, attributes);

            _descriptions.Add(description);

            return new ConstraintMakerExtendable(description);
        }

        public static void RemoveConstraints(LayoutConstraintItem item)
        {
            var constraints = item.Constraints;

            foreach (var constraint in constraints)
            {
                constraint.DeactivateIfNeeded();
            }
        }

        public static void MakeConstraints(LayoutConstraintItem item, Action<ConstraintMaker> closure)
        {
            var maker = new ConstraintMaker(item);

            closure(maker);

            var constraints = new List<Constraint>();

            foreach (var description in maker._descriptions)
            {
                if (description.Constraint != null)
                {
                    constraints.Add(description.Constraint);
                }
            }

            foreach (var constraint in constraints)
            {
                constraint.ActivateIfNeeded(updateExisting: false);
            }
        }

        public static void RemakeConstraints(LayoutConstraintItem item, Action<ConstraintMaker> closure)
        {
            RemoveConstraints(item);
            MakeConstraints(item, closure);
        }

        public static void UpdateConstraints(LayoutConstraintItem item, Action<ConstraintMaker> closure)
        {
            if (item.Constraints?.Length <= 0)
            {
                MakeConstraints(item, closure);
                return;
            }

            var maker = new ConstraintMaker(item);

            closure(maker);

            var constraints = new List<Constraint>();

            foreach (var description in maker._descriptions)
            {
                if (description.Constraint != null)
                {
                    constraints.Add(description.Constraint);
                }
            }

            foreach (var constraint in constraints)
            {
                constraint.ActivateIfNeeded(updateExisting: true);
            }
        }

        public static Constraint[] PrepareConstraints(LayoutConstraintItem item, Action<ConstraintMaker> closure)
        {
            var maker = new ConstraintMaker(item);

            closure(maker);

            var constraints = new List<Constraint>();

            foreach (var description in maker._descriptions)
            {
                if (description.Constraint != null)
                {
                    constraints.Add(description.Constraint);
                }
            }

            return constraints.ToArray();
        }
    }
}
