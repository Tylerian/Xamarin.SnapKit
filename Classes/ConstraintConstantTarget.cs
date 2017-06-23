using System;

using UIKit;
using CoreGraphics;

namespace SnapKit
{
    public class ConstraintConstantTarget
    {
        protected object _value;

        protected ConstraintConstantTarget(int value)
        {
            _value = value;
        }

        protected ConstraintConstantTarget(uint value)
        {
            _value = value;
        }

        protected ConstraintConstantTarget(float value)
        {
            _value = value;
        }

        protected ConstraintConstantTarget(double value)
        {
            _value = value;
        }

        protected ConstraintConstantTarget(nfloat value)
        {
            _value = value;
        }

        protected ConstraintConstantTarget(CGSize value)
        {
            _value = value;
        }

        protected ConstraintConstantTarget(CGPoint value)
        {
            _value = value;
        }

        protected ConstraintConstantTarget(UIEdgeInsets value)
        {
            _value = value;
        }

        public nfloat ValueForAttribute(NSLayoutAttribute attribute)
        {
            if (_value is int)
            {
                return (nfloat)_value;
            }

            if (_value is uint)
            {
                return (nfloat)_value;
            }


            if (_value is float)
            {
                return (nfloat)_value;
            }

            if (_value is nfloat)
            {
                return (nfloat)_value;
            }

            if (_value is CGSize)
            {
                var value = (CGSize)_value;

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

            if (_value is CGPoint)
            {
                var value = (CGPoint)_value;

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

            if (_value is UIEdgeInsets)
            {
                var value = (UIEdgeInsets)_value;

                switch (attribute)
                {
                    case NSLayoutAttribute.Left:
                    case NSLayoutAttribute.LeftMargin:
                    case NSLayoutAttribute.CenterX:
                    case NSLayoutAttribute.CenterXWithinMargins:
                        return value.Left;

                    case NSLayoutAttribute.Top:
                    case NSLayoutAttribute.TopMargin:
                    case NSLayoutAttribute.CenterY:
                    case NSLayoutAttribute.CenterYWithinMargins:
                    case NSLayoutAttribute.LastBaseline:
                    case NSLayoutAttribute.FirstBaseline:
                        return value.Top;

                    case NSLayoutAttribute.Right:
                    case NSLayoutAttribute.RightMargin:
                        return -value.Right;

                    case NSLayoutAttribute.Bottom:
                    case NSLayoutAttribute.BottomMargin:
                        return -value.Bottom;

                    case NSLayoutAttribute.Leading:
                    case NSLayoutAttribute.LeadingMargin:
                        return (ConstraintConfig.InterfaceLayoutDirection == UIUserInterfaceLayoutDirection.LeftToRight) ? value.Left : value.Right;

                    case NSLayoutAttribute.Trailing:
                    case NSLayoutAttribute.TrailingMargin:
                        return (ConstraintConfig.InterfaceLayoutDirection == UIUserInterfaceLayoutDirection.LeftToRight) ? -value.Right : -value.Left;
                    case NSLayoutAttribute.Width:
                        return -(value.Left + value.Right);
                    case NSLayoutAttribute.Height:
                        return -(value.Top + value.Bottom);
                    case NSLayoutAttribute.NoAttribute:
                        return 0.0f;
                }
            }

            return 0.0f;
        }

        public static implicit operator ConstraintConstantTarget(int value)
        {
            return new ConstraintConstantTarget(value);
        }

        public static implicit operator ConstraintConstantTarget(uint value)
        {
            return new ConstraintConstantTarget(value);
        }

        public static implicit operator ConstraintConstantTarget(float value)
        {
            return new ConstraintConstantTarget(value);
        }

        public static implicit operator ConstraintConstantTarget(double value)
        {
            return new ConstraintConstantTarget(value);
        }

        public static implicit operator ConstraintConstantTarget(nfloat value)
        {
            return new ConstraintConstantTarget(value);
        }

        public static implicit operator ConstraintConstantTarget(CGSize value)
        {
            return new ConstraintConstantTarget(value);
        }

        public static implicit operator ConstraintConstantTarget(CGPoint value)
        {
            return new ConstraintConstantTarget(value);
        }

        public static implicit operator ConstraintConstantTarget(UIEdgeInsets value)
        {
            return new ConstraintConstantTarget(value);
        }

        public static implicit operator nfloat(ConstraintConstantTarget value)
        {
            if (value._value is int)
            {
                return (nfloat)value._value;
            }

            if (value._value is uint)
            {
                return (nfloat)value._value;
            }
            
            if (value._value is float)
            {
                return (nfloat)value._value;
            }

            if (value._value is nfloat)
            {
                return (nfloat)value._value;
            }

            throw new InvalidCastException($"ConstraintConstantTarget<{value._value.GetType().Name}> cannot be casted to nfloat.");
        }
    }
}
