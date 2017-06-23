using System;
using System.Collections.Generic;
using System.Text;

namespace SnapKit
{
    public class ConstraintMakerEditable : ConstraintMakerPrioritizable
    {
        public ConstraintMakerEditable(ConstraintDescription description) : base(description) { }

        public ConstraintMakerEditable Inset(ConstraintInsetTarget amount)
        {
            Description.Constant = amount.TargetValue;
            return this;
        }

        public ConstraintMakerEditable Offset(ConstraintOffsetTarget amount)
        {
            Description.Constant = amount;
            return this;
        }

        public ConstraintMakerEditable DividedBy(ConstraintMultiplierTarget amount)
        {
            return MultipliedBy(1.0f / amount);
        }

        public ConstraintMakerEditable MultipliedBy(ConstraintMultiplierTarget amount)
        {
            Description.Multiplier = amount;

            return this;
        }
    }
}
