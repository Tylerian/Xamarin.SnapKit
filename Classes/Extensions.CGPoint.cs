using System;

using UIKit;
using CoreGraphics;

namespace SnapKit
{
    public static partial class Extensions
    {
        internal static nfloat ConstraintConstantTargetValueFor(this CGPoint value, NSLayoutAttribute attribute)
        {
            switch (attribute)
            {
                case NSLayoutAttribute.Left:
                case NSLayoutAttribute.Right:
                case NSLayoutAttribute.Leading:
                case NSLayoutAttribute.Trailing:
                case NSLayoutAttribute.CenterX:
                case NSLayoutAttribute.LeftMargin:
                case NSLayoutAttribute.RightMargin:
                case NSLayoutAttribute.LeadingMargin:
                case NSLayoutAttribute.TrailingMargin:
                case NSLayoutAttribute.CenterXWithinMargins:
                    return value.X;

                case NSLayoutAttribute.Top:
                case NSLayoutAttribute.Bottom:
                case NSLayoutAttribute.CenterY:
                case NSLayoutAttribute.TopMargin:
                case NSLayoutAttribute.BottomMargin:
                case NSLayoutAttribute.CenterYWithinMargins:
                case NSLayoutAttribute.LastBaseline:
                case NSLayoutAttribute.FirstBaseline:
                    return value.Y;

                case NSLayoutAttribute.Width:
                case NSLayoutAttribute.Height:
                case NSLayoutAttribute.NoAttribute:
                    return 0.0f;

                default:
                    return 0.0f; 
            }
        }
    }
}
