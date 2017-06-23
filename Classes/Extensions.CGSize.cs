using System;

using UIKit;
using CoreGraphics;

namespace SnapKit
{
    public static partial class Extensions
    {
        internal static nfloat ConstraintConstantTargetValueFor(this CGSize value, NSLayoutAttribute attribute)
        {
            if (attribute == NSLayoutAttribute.Width)
            {
                return value.Width;
            }

            if (attribute == NSLayoutAttribute.Height)
            {
                return value.Height;
            }

            return 0.0f;
        }
    }
}
