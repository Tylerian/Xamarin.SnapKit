using System;

namespace SnapKit
{
    public class ConstraintDescription
    {
        internal string Label
        {
            get;
            set;
        }

        internal ConstraintItem Related
        {
            get;
            set;
        }

        internal ConstraintRelation Relation
        {
            get;
            set;
        }

        internal LayoutConstraintItem Item
        {
            get;
        }

        internal ConstraintAttributes Attributes
        {
            get;
            set;
        }

        internal Tuple<string, uint> SourceLocation
        {
            get;
            set;
        }

        internal ConstraintConstantTarget Constant
        {
            get;
            set;
        }

        internal ConstraintPriorityTarget Priority
        {
            get;
            set;
        }

        internal ConstraintMultiplierTarget Multiplier
        {
            get;
            set;
        }

        internal Constraint Constraint
        {
            get
            {
                return (Relation != null || Related != null || SourceLocation != null) ? new Constraint(new ConstraintItem(Item, Attributes), Related, Relation, SourceLocation, Multiplier, Constant, Priority, Label) : null;
            }
        }

        internal static ConstraintDescription[] Empty
        {
            get;
        }

        static ConstraintDescription()
        {
            Empty = new ConstraintDescription[0];
        }

        public ConstraintDescription(LayoutConstraintItem item, ConstraintAttributes attributes)
        {
            Item       = item;
            Constant   = 0.0f;
            Priority   = 1000.0f;
            Multiplier = 1.0f;
            Attributes = attributes;
        }
    }
}
