using System;
using System.Collections.Generic;
using System.Text;

namespace SnapKit
{
    public class ConstraintMakerPrioritizable : ConstraintMakerFinalizable
    {
        public ConstraintMakerPrioritizable(ConstraintDescription description) : base(description) { }

        public ConstraintMakerPrioritizable Priority(ConstraintPriorityTarget amount)
        {
            Description.Priority = amount;
            return this;
        }

        public ConstraintMakerPrioritizable PriorityLow()
        {
            return Priority(250.0f);
        }

        public ConstraintMakerPrioritizable PriorityHigh()
        {
            return Priority(750.0f);
        }

        public ConstraintMakerPrioritizable PriorityMedium()
        {
            return Priority(500.0f);
        }

        public ConstraintMakerPrioritizable PriorityRequired()
        {
            return Priority(1000.0f);
        }
    }
}
