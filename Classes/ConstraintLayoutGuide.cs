using System;

using UIKit;

namespace SnapKit
{
    public class ConstraintLayoutGuide
    {
        private UILayoutGuide _value;

        public UILayoutGuide Value
        {
            get
            {
                return _value;
            }
        }

        public ConstraintLayoutGuideDSL Snap
        {
            get
            {
                return new ConstraintLayoutGuideDSL(this);
            }
        }

        private ConstraintLayoutGuide(UILayoutGuide guide)
        {
            _value = guide;
        }

        public static implicit operator UILayoutGuide(ConstraintLayoutGuide value)
        {
            return value._value;
        }

        public static implicit operator ConstraintLayoutGuide(UILayoutGuide value)
        {
            return new ConstraintLayoutGuide(value);
        }
    }
}
