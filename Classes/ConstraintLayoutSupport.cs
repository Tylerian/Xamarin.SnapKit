using System;

using UIKit;

namespace SnapKit
{
    public class ConstraintLayoutSupport
    {
        private UILayoutSupport _value;

        private ConstraintLayoutSupport(UILayoutSupport guide)
        {
            _value = guide;
        }

        public static implicit operator UILayoutSupport(ConstraintLayoutSupport value)
        {
            return value._value;
        }

        public static implicit operator ConstraintLayoutSupport(UILayoutSupport value)
        {
            return new ConstraintLayoutSupport(value);
        }
    }
}
