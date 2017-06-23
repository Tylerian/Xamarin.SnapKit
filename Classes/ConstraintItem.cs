using System;

using UIKit;

namespace SnapKit
{
    public sealed class ConstraintItem
    {
        internal object Target
        {
            get;
        }

        internal ConstraintAttributes Attributes
        {
            get;
        }

        internal LayoutConstraintItem LayoutConstraintItem
        {
            get
            {
                return Target as LayoutConstraintItem;
            }
            
        }

        internal ConstraintItem(object target, ConstraintAttributes attributes)
        {
            Target = target;
            Attributes = attributes;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var equals = false;

            if (equals = obj is ConstraintItem)
            {
                var cast = (ConstraintItem) obj;

                if (ReferenceEquals(this, cast))
                {
                    return true;
                }

                var target1 = Target;
                var target2 = cast.Target;

                return ReferenceEquals(target1, target2) && Attributes == cast.Attributes;
            }

            return equals;
        }

        public static bool operator ==(ConstraintItem lhs, ConstraintItem rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(ConstraintItem lhs, ConstraintItem rhs)
        {
            return !(lhs == rhs);
        }
    }
}
