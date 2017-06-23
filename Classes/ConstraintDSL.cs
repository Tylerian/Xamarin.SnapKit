using System;

using UIKit;

namespace SnapKit
{
    public abstract class ConstraintDSL
    {
        public string Label
        {
            get;
            set;
        }

        public abstract object Target
        {
            get;
        }
    }

    public abstract class ConstraintBasicAttributesDSL : ConstraintDSL
    {
        public ConstraintItem Top
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Top);
            }
        }

        public ConstraintItem Left
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Left);
            }
        }

        public ConstraintItem Bottom
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Bottom);
            }
        }

        public ConstraintItem Right
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Right);
            }
        }

        public ConstraintItem Leading
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Leading);
            }
        }

        public ConstraintItem Trailing
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Trailing);
            }
        }

        public ConstraintItem Width
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Width);
            }
        }

        public ConstraintItem Height
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Height);
            }
        }

        public ConstraintItem Center
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Center);
            }
        }

        public ConstraintItem CenterX
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.CenterX);
            }
        }

        public ConstraintItem CenterY
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.CenterY);
            }
        }

        public ConstraintItem Edges
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Edges);
            }
        }

        public ConstraintItem Size
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Size);
            }
        }
    }

    public abstract class ConstraintAttributesDSL : ConstraintBasicAttributesDSL
    {
        public ConstraintItem Baseline
        {
            get
            {
                return LastBaseline;
            }
        }

        public ConstraintItem LastBaseline
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.LastBaseline);
            }
        }

        public ConstraintItem FirstBaseline
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.FirstBaseline);
            }
        }

        public ConstraintItem Margins
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.Margins);
            }
        }

        public ConstraintItem TopMargin
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.TopMargin);
            }
        }
        public ConstraintItem LeftMargin
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.LeftMargin);
            }
        }
        public ConstraintItem BottomMargin
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.BottomMargin);
            }
        }
        public ConstraintItem RightMargin
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.RightMargin);
            }
        }
        public ConstraintItem LeadingMargin
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.LeadingMargin);
            }
        }

        public ConstraintItem TrailingMargin
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.TrailingMargin);
            }
        }

        public ConstraintItem CenterWithinMargins
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.CenterWithinMargins);
            }
        }

        public ConstraintItem CenterXWithinMargins
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.CenterXWithinMargins);
            }
        }

        public ConstraintItem CenterYWithinMargins
        {
            get
            {
                return new ConstraintItem(target: Target, attributes: ConstraintAttributes.CenterYWithinMargins);
            }
        }
    }
}
