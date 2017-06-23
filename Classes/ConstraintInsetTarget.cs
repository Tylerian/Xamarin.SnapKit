using System;

using UIKit;

namespace SnapKit
{
    public class ConstraintInsetTarget : ConstraintConstantTarget
    {
        public UIEdgeInsets TargetValue
        {
            get
            {
                if (_value is UIEdgeInsets)
                {
                    return (UIEdgeInsets) _value;
                }

                if (_value is int)
                {
                    return new UIEdgeInsets((int)_value, (int)_value, (int)_value, (int)_value);
                }

                if (_value is uint)
                {
                    return new UIEdgeInsets((uint)_value, (uint)_value, (uint)_value, (uint)_value);
                }

                if (_value is float)
                {
                    return new UIEdgeInsets((float)_value, (float)_value, (float)_value, (float)_value);
                }

                if (_value is nfloat)
                {
                    return new UIEdgeInsets((nfloat)_value, (nfloat)_value, (nfloat)_value, (nfloat)_value);
                }

                if (_value is double)
                {
                    return new UIEdgeInsets((nfloat)(double)_value, (nfloat)(double)_value, (nfloat)(double)_value, (nfloat)(double)_value);
                }

                return new UIEdgeInsets(0, 0, 0, 0);
            }
        }

        private ConstraintInsetTarget(int value) : base(value)
        {
            _value = value;
        }

        private ConstraintInsetTarget(uint value) : base(value)
        {
            _value = value;
        }

        private ConstraintInsetTarget(float value) : base(value)
        {
            _value = value;
        }

        private ConstraintInsetTarget(double value) : base(value)
        {
            _value = value;
        }

        private ConstraintInsetTarget(nfloat value) : base(value)
        {
            _value = value;
        }

        private ConstraintInsetTarget(UIEdgeInsets value) : base(value)
        {
            _value = value;
        }

        public static implicit operator ConstraintInsetTarget(int value)
        {
            return new ConstraintInsetTarget(value);
        }

        public static implicit operator ConstraintInsetTarget(uint value)
        {
            return new ConstraintInsetTarget(value);
        }

        public static implicit operator ConstraintInsetTarget(float value)
        {
            return new ConstraintInsetTarget(value);
        }

        public static implicit operator ConstraintInsetTarget(double value)
        {
            return new ConstraintInsetTarget(value);
        }

        public static implicit operator ConstraintInsetTarget(nfloat value)
        {
            return new ConstraintInsetTarget(value);
        }

        public static implicit operator ConstraintInsetTarget(UIEdgeInsets value)
        {
            return new ConstraintInsetTarget(value);
        }
    }
}
