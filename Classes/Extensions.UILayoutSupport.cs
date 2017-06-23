using System;
using UIKit;

namespace SnapKit
{
    public static partial class Extensions
    {
        public static ConstraintLayoutSupportDSL Snap(this UILayoutSupport @this)
        {
            return new ConstraintLayoutSupportDSL(@this);
        }
    }
}
