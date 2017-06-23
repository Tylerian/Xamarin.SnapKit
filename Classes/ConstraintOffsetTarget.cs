using System;
using System.Collections.Generic;
using System.Text;

namespace SnapKit
{
    public class ConstraintOffsetTarget : ConstraintConstantTarget
    {
        private ConstraintOffsetTarget(int value) : base(value)
        {
            _value = value;
        }

        private ConstraintOffsetTarget(uint value) : base(value)
        {
            _value = value;
        }

        private ConstraintOffsetTarget(float value) : base(value)
        {
            _value = value;
        }

        private ConstraintOffsetTarget(double value) : base(value)
        {
            _value = (float)value;
        }

        private ConstraintOffsetTarget(nfloat value) : base(value)
        {
            _value = value;
        }

        public static implicit operator ConstraintOffsetTarget(int value)
        {
            return new ConstraintOffsetTarget(value);
        }

        public static implicit operator ConstraintOffsetTarget(uint value)
        {
            return new ConstraintOffsetTarget(value);
        }

        public static implicit operator ConstraintOffsetTarget(float value)
        {
            return new ConstraintOffsetTarget(value);
        }

        public static implicit operator ConstraintOffsetTarget(double value)
        {
            return new ConstraintOffsetTarget(value);
        }

        public static implicit operator ConstraintOffsetTarget(nfloat value)
        {
            return new ConstraintOffsetTarget(value);
        }

        public static implicit operator nfloat(ConstraintOffsetTarget value)
        {
            if (value._value is int)
            {
                return (nfloat)value._value;
            }

            if (value._value is uint)
            {
                return (nfloat)value._value;
            }

            if (value._value is float)
            {
                return (nfloat)value._value;
            }

            if (value._value is nfloat)
            {
                return (nfloat)value._value;
            }

            return 0.0f;
        }
    }
}
