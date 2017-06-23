using System;
using System.Collections.Generic;
using System.Text;

namespace SnapKit
{
    public enum ConstraintAttributes
    {
        None = 0,

        Left     = 1 << 0,
        Top      = 1 << 1,
        Right    = 1 << 2,
        Bottom   = 1 << 3,
        Leading  = 1 << 4,
        Trailing = 1 << 5,

        Width  = 1 << 6,
        Height = 1 << 7,

        CenterX = 1 << 8,
        CenterY = 1 << 9,

        LastBaseline  = 1 << 10,
        FirstBaseline = 1 << 11,


        LeftMargin     = 1 << 12,
        RightMargin    = 1 << 13,
        TopMargin      = 1 << 14,
        BottomMargin   = 1 << 15,
        LeadingMargin  = 1 << 16,
        TrailingMargin = 1 << 17,

        CenterXWithinMargins = 1 << 18,
        CenterYWithinMargins = 1 << 19,

        Edges = 15,
        Size  = 192,
        Center = 768,
        Margins = 61440,
        CenterWithinMargins = 786432
    }
}