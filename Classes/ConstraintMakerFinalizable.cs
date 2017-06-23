using System;
using System.Collections.Generic;
using System.Text;

namespace SnapKit
{
    public class ConstraintMakerFinalizable
    {
        public Constraint Constraint
        {
            get
            {
                return Description.Constraint;
            }
        }

        internal ConstraintDescription Description
        {
            get;
        }

        internal ConstraintMakerFinalizable(ConstraintDescription description)
        {
            Description = description;
        }

        public ConstraintMakerFinalizable Labeled(string label)
        {
            Description.Label = label;
            return this;
        }
    }
}
