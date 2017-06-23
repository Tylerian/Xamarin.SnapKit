using System;

using UIKit;

namespace SnapKit
{
    public class ConstraintLayoutSupportDSL : ConstraintDSL
    {
        public override object Target
        {
            get
            {
                return Support;
            }
        }

        internal ConstraintLayoutSupport Support
        {
            get;
        }

        public ConstraintItem Top
        {
            get
            {
                return new ConstraintItem(Target, ConstraintAttributes.Top);
            }
        }

        public ConstraintItem Bottom
        {
            get
            {
                return new ConstraintItem(Target, ConstraintAttributes.Bottom);
            }
        }

        public ConstraintItem Height
        {
            get
            {
                return new ConstraintItem(Target, ConstraintAttributes.Height);
            }
        }

        public ConstraintLayoutSupportDSL(ConstraintLayoutSupport support)
        {
            Support = support;
        }
    }
}
