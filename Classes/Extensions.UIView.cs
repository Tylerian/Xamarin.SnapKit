using UIKit;

namespace SnapKit
{
    public static partial class Extensions
    {
        public static ConstraintViewDSL Snap(this UIView @this)
        {
            return new ConstraintViewDSL(@this);
        }
    }
}
