using System;

using UIKit;

namespace SnapKit
{
    public static partial class Extensions
    {
        public static NSLayoutRelation LayoutRelation(this ConstraintRelation @this)
        {
            switch (@this)
            {
                default:
                case ConstraintRelation.Equal:
                    return NSLayoutRelation.Equal;

                case ConstraintRelation.LessThanOrEqual:
                    return NSLayoutRelation.LessThanOrEqual;

                case ConstraintRelation.GreaterThanOrEqual:
                    return NSLayoutRelation.GreaterThanOrEqual;
            }
        }
    }
}
