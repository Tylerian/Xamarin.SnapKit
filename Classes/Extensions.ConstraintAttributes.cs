using System;
using System.Collections.Generic;

using UIKit;

namespace SnapKit
{
    public static partial class Extensions
    {
        internal static NSLayoutAttribute[] LayoutAttributes(this ConstraintAttributes @this)
        {
            var attrs = new List<NSLayoutAttribute>();

            if (@this.Contains(ConstraintAttributes.Top))
            {
                attrs.Add(NSLayoutAttribute.Top);
            }

            if (@this.Contains(ConstraintAttributes.Left))
            {
                attrs.Add(NSLayoutAttribute.Left);
            }

            if (@this.Contains(ConstraintAttributes.Right))
            {
                attrs.Add(NSLayoutAttribute.Right);
            }

            if (@this.Contains(ConstraintAttributes.Bottom))
            {
                attrs.Add(NSLayoutAttribute.Bottom);
            }

            if (@this.Contains(ConstraintAttributes.Leading))
            {
                attrs.Add(NSLayoutAttribute.Leading);
            }

            if (@this.Contains(ConstraintAttributes.Trailing))
            {
                attrs.Add(NSLayoutAttribute.Trailing);
            }

            if (@this.Contains(ConstraintAttributes.Width))
            {
                attrs.Add(NSLayoutAttribute.Width);
            }

            if (@this.Contains(ConstraintAttributes.Height))
            {
                attrs.Add(NSLayoutAttribute.Height);
            }

            if (@this.Contains(ConstraintAttributes.CenterX))
            {
                attrs.Add(NSLayoutAttribute.CenterX);
            }

            if (@this.Contains(ConstraintAttributes.CenterY))
            {
                attrs.Add(NSLayoutAttribute.CenterY);
            }

            if (@this.Contains(ConstraintAttributes.LastBaseline))
            {
                attrs.Add(NSLayoutAttribute.LastBaseline);
            }

            if (@this.Contains(ConstraintAttributes.FirstBaseline))
            {
                attrs.Add(NSLayoutAttribute.FirstBaseline);
            }

            if (@this.Contains(ConstraintAttributes.LeftMargin))
            {
                attrs.Add(NSLayoutAttribute.LeftMargin);
            }

            if (@this.Contains(ConstraintAttributes.RightMargin))
            {
                attrs.Add(NSLayoutAttribute.RightMargin);
            }

            if (@this.Contains(ConstraintAttributes.TopMargin))
            {
                attrs.Add(NSLayoutAttribute.TopMargin);
            }

            if (@this.Contains(ConstraintAttributes.BottomMargin))
            {
                attrs.Add(NSLayoutAttribute.BottomMargin);
            }

            if (@this.Contains(ConstraintAttributes.LeadingMargin))
            {
                attrs.Add(NSLayoutAttribute.LeadingMargin);
            }

            if (@this.Contains(ConstraintAttributes.TrailingMargin))
            {
                attrs.Add(NSLayoutAttribute.TrailingMargin);
            }

            if (@this.Contains(ConstraintAttributes.CenterXWithinMargins))
            {
                attrs.Add(NSLayoutAttribute.CenterXWithinMargins);
            }

            if (@this.Contains(ConstraintAttributes.CenterYWithinMargins))
            {
                attrs.Add(NSLayoutAttribute.CenterYWithinMargins);
            }

            return attrs.ToArray();
        }

        internal static bool Equals(this ConstraintAttributes @this, ConstraintAttributes attribute)
        {
            return @this == attribute;
        }

        internal static bool Contains(this ConstraintAttributes @this, ConstraintAttributes attribute)
        {
            return (@this & attribute) == attribute;
        }
    }
}
