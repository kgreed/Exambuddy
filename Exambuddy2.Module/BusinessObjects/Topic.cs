using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    public class Topic : BasicBo
    {
        public Topic()
        {
            Sources = new List<Source>();
        }

        public override BasicBo Parent
        {
            get => CourseUnit;
            set
            {
                var bo = value;
                CourseUnit = bo.ObjectSpace.FindObject<CourseUnit>(CriteriaOperator.Parse("[Id]=? ", bo.Id));
            }
        }
        [RuleRequiredField(DefaultContexts.Save)]
        public string Name { get; set; }
        public int Week { get; set; }
        [Browsable(false)]
        [RuleRequiredField(DefaultContexts.Save)]
        public int CourseUnitId { get; set; }
        [Browsable(true)]
        [ForeignKey("CourseUnitId")]  public virtual CourseUnit CourseUnit { get; set; }
         public virtual IList<Source> Sources { get; set; }
        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string TopicNotes { get; set; }
        public override void AddChild(BasicBo child)
        {
            base.AddChild(child);
            Sources.Add(child as Source);
        }
    }
}