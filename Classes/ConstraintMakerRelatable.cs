using System;

using UIKit;

namespace SnapKit
{
    public class ConstraintMakerRelatable
    {
        internal ConstraintDescription Description
        {
            get;
        }

        internal ConstraintMakerRelatable(ConstraintDescription description)
        {
            Description = description;
        }

        public ConstraintMakerEditable EqualTo(ConstraintRelatableTarget other, string file, uint line)
        {
            return RelatedTo(other, ConstraintRelation.Equal, file, line);
        }

        public ConstraintMakerEditable EqualToSuperview(ConstraintRelatableTarget other, string file, uint line)
        {
            if (Description.Item.Superview != null)
            {
                return RelatedTo(Description.Item.Superview, ConstraintRelation.Equal, file, line);
            }

            throw new ArgumentNullException("Expected superview but found null when attempting make constraint `equalToSuperview`.");
        }

        public ConstraintMakerEditable LessThanOrEqualTo(ConstraintRelatableTarget other, string file, uint line)
        {
            return RelatedTo(other, ConstraintRelation.LessThanOrEqual, file, line);
        }

        public ConstraintMakerEditable LessThanOrEqualToSuperview(ConstraintRelatableTarget other, string file, uint line)
        {
            if (Description.Item.Superview != null)
            {
                return RelatedTo(Description.Item.Superview, ConstraintRelation.LessThanOrEqual, file, line);
            }

            throw new ArgumentNullException("Expected superview but found null when attempting make constraint `equalToSuperview`.");
        }

        public ConstraintMakerEditable GreatherThanOrEqualTo(ConstraintRelatableTarget other, string file, uint line)
        {
            return RelatedTo(other, ConstraintRelation.GreaterThanOrEqual, file, line);
        }

        public ConstraintMakerEditable GreatherThanOrEqualToSuperview(ConstraintRelatableTarget other, string file, uint line)
        {
            if (Description.Item.Superview != null)
            {
                return RelatedTo(Description.Item.Superview, ConstraintRelation.GreaterThanOrEqual, file, line);
            }

            throw new ArgumentNullException("Expected superview but found null when attempting make constraint `equalToSuperview`.");
        }

        internal ConstraintMakerEditable RelatedTo(ConstraintRelatableTarget other, ConstraintRelation relation, string file, uint line)
        {
            var related  = (ConstraintItem)null;
            var constant = (ConstraintConstantTarget)null;
            
            if (other.Value is UIView)
            {
                constant = 0.0f;
                related  = new ConstraintItem(other.Value, ConstraintAttributes.None);
            }

            else if (other.Value is ConstraintItem)
            {
                constant = 0.0f;
                related  = (ConstraintItem)other.Value;
            }

            else if (other.Value is ConstraintLayoutGuide)
            {
                constant = 0.0f;
                related  = new ConstraintItem(other.Value, ConstraintAttributes.None);
            }

            else if (other.Value is ConstraintConstantTarget)
            {
                constant = (ConstraintConstantTarget) other.Value;
                related  = new ConstraintItem(null, ConstraintAttributes.None);
            }

            else
            {
                Console.WriteLine($"[ERROR] -- Invalid constraint. {file}:{line}");
            }

            var editable = new ConstraintMakerEditable(Description);

            editable.Description.SourceLocation = new Tuple<string, uint>(file, line);
            editable.Description.Relation = relation;
            editable.Description.Related = related;
            editable.Description.Constant = constant;

            return editable;
        }
    }
}