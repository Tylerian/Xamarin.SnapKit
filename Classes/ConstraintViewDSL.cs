using System;

using UIKit;

namespace SnapKit
{
    public class ConstraintViewDSL : ConstraintAttributesDSL
    {
        internal UIView View
        {
            get;
        }

        public override object Target
        {
            get
            {
                return View;
            }
        }

        public float ContentHuggingVerticalPriority
        {
            get
            {
                return View.ContentHuggingPriority(UILayoutConstraintAxis.Vertical);
            }

            set
            {
                View.SetContentHuggingPriority(value, UILayoutConstraintAxis.Vertical);
            }
        }

        public float ContentHuggingHorizontalPriority
        {
            get
            {
                return View.ContentHuggingPriority(UILayoutConstraintAxis.Horizontal);
            }

            set
            {
                View.SetContentHuggingPriority(value, UILayoutConstraintAxis.Horizontal);
            }
        }

        public float ContentCompressionResistanceVerticalPriority
        {
            get
            {
                return View.ContentCompressionResistancePriority(UILayoutConstraintAxis.Vertical);
            }

            set
            {
                View.SetContentCompressionResistancePriority(value, UILayoutConstraintAxis.Vertical);
            }
        }

        public float ContentCompressionResistanceHorizontalPriority
        {
            get
            {
                return View.ContentCompressionResistancePriority(UILayoutConstraintAxis.Horizontal);
            }

            set
            {
                View.SetContentCompressionResistancePriority(value, UILayoutConstraintAxis.Horizontal);
            }
        }

        public ConstraintViewDSL(UIView view)
        {
            View = view;
        }

        public void RemoveConstraints()
        {
            ConstraintMaker.RemoveConstraints(View);
        }

        public void MakeConstraints(Action<ConstraintMaker> closure)
        {
            ConstraintMaker.MakeConstraints(View, closure);
        }

        public void RemakeConstraints(Action<ConstraintMaker> closure)
        {
            ConstraintMaker.RemakeConstraints(View, closure);
        }

        public void UpdateConstraints(Action<ConstraintMaker> closure)
        {
            ConstraintMaker.UpdateConstraints(View, closure);
        }

        public Constraint[] PrepareConstraints(Action<ConstraintMaker> closure)
        {
            return ConstraintMaker.PrepareConstraints(View, closure);
        }
    }
}
