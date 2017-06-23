using System;

using UIKit;
using CoreGraphics;

namespace SnapKit
{
    public struct ConstraintRelatableTarget
    {
        private object _value;

        public object Value
        {
            get
            {
                return _value;
            }
        }

        private ConstraintRelatableTarget(int value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(uint value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(float value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(double value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(nfloat value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(CGSize value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(CGPoint value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(UIView value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(UIEdgeInsets value)
        {
            _value = value;
        }

        private ConstraintRelatableTarget(ConstraintItem value)
        {
            _value = value;
        }
        
        public static implicit operator ConstraintRelatableTarget(int value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(uint value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(float value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(double value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(nfloat value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(CGSize value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(CGPoint value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(UIView value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(UIEdgeInsets value)
        {
            return new ConstraintRelatableTarget(value);
        }

        public static implicit operator ConstraintRelatableTarget(ConstraintItem value)
        {
            return new ConstraintRelatableTarget(value);
        }
    }
}
