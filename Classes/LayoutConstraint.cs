using System;

using UIKit;
using Foundation;

namespace SnapKit
{
    public class LayoutConstraint
    {
        private NSLayoutConstraint _value;

        public string Label
        {
            get
            {
                return _value?.GetIdentifier();
            }

            set
            {
                _value?.SetIdentifier(value);
            }
        }

        internal Constraint Constraint
        {
            get;
        }

        internal NSLayoutConstraint Value
        {
            get
            {
                return _value;
            }
        }

        private LayoutConstraint(NSLayoutConstraint value)
        {
            _value = value;
        }

        public LayoutConstraint(LayoutConstraintItem itemA, NSLayoutAttribute attributeA, NSLayoutRelation relation, UIView itemB, NSLayoutAttribute attributeB, nfloat multiplier, nfloat constant)
        {
            _value = NSLayoutConstraint.Create(itemA.Value, attributeA, relation, itemB, attributeB, multiplier, constant);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            if (equals = obj is LayoutConstraint)
            {
                var rhs = ((LayoutConstraint)obj)._value;

                equals = (
                       ReferenceEquals(_value.FirstItem, rhs.FirstItem)
                    && ReferenceEquals(_value.SecondItem, rhs.SecondItem)
                    && ReferenceEquals(_value.FirstAttribute, rhs.FirstAttribute)
                    && ReferenceEquals(_value.SecondAttribute, rhs.SecondAttribute)
                    && ReferenceEquals(_value.Relation, rhs.Relation)

                    && _value.Priority   == rhs.Priority
                    && _value.Multiplier == rhs.Multiplier
                );
            }

            return equals;
        }

        public static implicit operator LayoutConstraint(NSLayoutConstraint value)
        {
            return new LayoutConstraint(value);
        }

        public static bool operator ==(LayoutConstraint lhs, LayoutConstraint rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(LayoutConstraint lhs, LayoutConstraint rhs)
        {
            return !(lhs == rhs);
        }
    }
}
