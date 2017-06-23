using System;
using System.Collections.Generic;
using System.Text;

namespace SnapKit
{
    public class ConstraintLayoutGuideDSL : ConstraintAttributesDSL
    {
        public override object Target
        {
            get
            {
                return Guide;
            }
        }

        internal ConstraintLayoutGuide Guide
        {
            get;
        }

        public ConstraintLayoutGuideDSL(ConstraintLayoutGuide guide)
        {
            Guide = guide;
        }

        public void RemoveConstraints()
        {
            ConstraintMaker.RemoveConstraints(Guide);
        }

        public void MakeConstraints(Action<ConstraintMaker> closure)
        {
            ConstraintMaker.MakeConstraints(Guide, closure);
        }

        public void RemakeConstraints(Action<ConstraintMaker> closure)
        {
            ConstraintMaker.RemakeConstraints(Guide, closure);
        }

        public void UpdateConstraints(Action<ConstraintMaker> closure)
        {
            ConstraintMaker.UpdateConstraints(Guide, closure);
        }

        public Constraint[] PrepareConstraints(Action<ConstraintMaker> closure)
        {
            return ConstraintMaker.PrepareConstraints(Guide, closure);
        }
    }
}
