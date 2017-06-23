using System;
using System.Collections.Generic;
using System.Text;

using UIKit;

namespace SnapKit
{
    public class ConstraintPriorityTarget
    {
        private nfloat _value;

        private ConstraintPriorityTarget(int value)
        {
            _value = value;
        }

        private ConstraintPriorityTarget(uint value)
        {
            _value = value;
        }

        private ConstraintPriorityTarget(float value)
        {
            _value = value;
        }

        private ConstraintPriorityTarget(double value)
        {
            _value = (float)value;
        }

        private ConstraintPriorityTarget(nfloat value)
        {
            _value = value;
        }

        public static implicit operator ConstraintPriorityTarget(int value)
        {
            return new ConstraintPriorityTarget(value);
        }

        public static implicit operator ConstraintPriorityTarget(uint value)
        {
            return new ConstraintPriorityTarget(value);
        }

        public static implicit operator ConstraintPriorityTarget(float value)
        {
            return new ConstraintPriorityTarget(value);
        }

        public static implicit operator ConstraintPriorityTarget(double value)
        {
            return new ConstraintPriorityTarget(value);
        }

        public static implicit operator ConstraintPriorityTarget(nfloat value)
        {
            return new ConstraintPriorityTarget(value);
        }

        public static implicit operator  float(ConstraintPriorityTarget value)
        {
            return value._value;
        }

        public static implicit operator nfloat(ConstraintPriorityTarget value)
        {
            return value._value;
        }

        public static bool operator <(ConstraintPriorityTarget lhs, UILayoutPriority rhs)
        {
            return lhs._value < (int)rhs;
        }

        public static bool operator >(ConstraintPriorityTarget lhs, UILayoutPriority rhs)
        {
            return lhs._value > (int)rhs;
        }

        public static bool operator ==(ConstraintPriorityTarget lhs, UILayoutPriority rhs)
        {
            return lhs._value == (int)rhs;
        }

        public static bool operator !=(ConstraintPriorityTarget lhs, UILayoutPriority rhs)
        {
            return lhs._value != (int)rhs;
        }
    }
}
