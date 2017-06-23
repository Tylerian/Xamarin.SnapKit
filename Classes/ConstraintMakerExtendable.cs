using System;
using System.Collections.Generic;
using System.Text;

namespace SnapKit
{
    public class ConstraintMakerExtendable : ConstraintMakerRelatable
    {
        public ConstraintMakerExtendable Top
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Top;
                return this;
            }
        }

        public ConstraintMakerExtendable Left
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Left;
                return this;
            }
        }

        public ConstraintMakerExtendable Bottom
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Bottom;
                return this;
            }
        }

        public ConstraintMakerExtendable Right
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Right;
                return this;
            }
        }

        public ConstraintMakerExtendable Leading
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Leading;
                return this;
            }
        }

        public ConstraintMakerExtendable Trailing
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Trailing;
                return this;
            }
        }

        public ConstraintMakerExtendable Width
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Width;
                return this;
            }
        }

        public ConstraintMakerExtendable Height
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Height;
                return this;
            }
        }

        public ConstraintMakerExtendable CenterX
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.CenterX;
                return this;
            }
        }

        public ConstraintMakerExtendable CenterY
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.CenterY;
                return this;
            }
        }

        public ConstraintMakerExtendable Baseline
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.FirstBaseline;
                return this;
            }
        }

        public ConstraintMakerExtendable LastBaseline
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.LastBaseline;
                return this;
            }
        }

        public ConstraintMakerExtendable FirstBaseline
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.FirstBaseline;
                return this;
            }
        }

        public ConstraintMakerExtendable TopMargin
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.TopMargin;
                return this;
            }
        }

        public ConstraintMakerExtendable LeftMargin
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.LeftMargin;
                return this;
            }
        }

        public ConstraintMakerExtendable BottomMargin
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.BottomMargin;
                return this;
            }
        }

        public ConstraintMakerExtendable RightMargin
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.RightMargin;
                return this;
            }
        }

        public ConstraintMakerExtendable LeadingMargin
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.LeadingMargin;
                return this;
            }
        }

        public ConstraintMakerExtendable TrailingMargin
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.TrailingMargin;
                return this;
            }
        }

        public ConstraintMakerExtendable CenterXWithinMargins
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.CenterXWithinMargins;
                return this;
            }
        }

        public ConstraintMakerExtendable CenterYWithinMargins
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.CenterYWithinMargins;
                return this;
            }
        }

        public ConstraintMakerExtendable Edges
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Edges;
                return this;
            }
        }

        public ConstraintMakerExtendable Size
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Size;
                return this;
            }
        }

        public ConstraintMakerExtendable Margins
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.Margins;
                return this;
            }
        }

        public ConstraintMakerExtendable CenterWithinMargins
        {
            get
            {
                Description.Attributes = Description.Attributes | ConstraintAttributes.CenterWithinMargins;
                return this;
            }
        }

        public ConstraintMakerExtendable(ConstraintDescription description) : base(description) { }
    }
}
