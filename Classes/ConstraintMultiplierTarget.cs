using System;
using System.Collections.Generic;
using System.Text;

namespace SnapKit
{
    public class ConstraintMultiplierTarget
    {
        private nfloat _value;
        
        private ConstraintMultiplierTarget(int value)
        {
            _value = value;
        }

        private ConstraintMultiplierTarget(uint value)
        {
            _value = value;
        }

        private ConstraintMultiplierTarget(float value)
        {
            _value = value;
        }

        private ConstraintMultiplierTarget(double value)
        {
            _value = (float) value;
        }

        private ConstraintMultiplierTarget(nfloat value)
        {
            _value = value;
        }

        public static implicit operator ConstraintMultiplierTarget(int value)
        {
            return new ConstraintMultiplierTarget(value);
        }

        public static implicit operator ConstraintMultiplierTarget(uint value)
        {
            return new ConstraintMultiplierTarget(value);
        }

        public static implicit operator ConstraintMultiplierTarget(float value)
        {
            return new ConstraintMultiplierTarget(value);
        }

        public static implicit operator ConstraintMultiplierTarget(double value)
        {
            return new ConstraintMultiplierTarget(value);
        }

        public static implicit operator ConstraintMultiplierTarget(nfloat value)
        {
            return new ConstraintMultiplierTarget(value);
        }

        public static implicit operator nfloat(ConstraintMultiplierTarget value)
        {
            return value._value;
        }

        public static nfloat operator *(ConstraintMultiplierTarget lhs, float m)
        {
            return lhs._value * m;
        }

        public static nfloat operator *(float m, ConstraintMultiplierTarget rhs)
        {
            return m * rhs;
        }

        public static nfloat operator /(float m, ConstraintMultiplierTarget rhs)
        {
            return (float)(m / rhs._value);
        }

        public static nfloat operator /(ConstraintMultiplierTarget lhs, float m)
        {
            return (float)(lhs._value / m);
        }
    }
}
