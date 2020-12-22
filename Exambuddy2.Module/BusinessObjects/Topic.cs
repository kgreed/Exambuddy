using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
//using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    public class Topic : BasicBo
    {
        public Topic()
        {
            Questions = new List<Question>();
        }

        public override BasicBo Parent
        {
            get => CourseUnit;
            set
            {
                var bo = value;
                var attachedBo = bo.ObjectSpace.FindObject<CourseUnit>(CriteriaOperator.Parse("[Id]=? ", bo.Id));
                CourseUnit = attachedBo;
            }
        }
     
        public string Name { get; set; }
        public int Week { get; set; }
        [Browsable(false)] public int CourseUnitId { get; set; }
        [ForeignKey("CourseUnitId")] public virtual CourseUnit CourseUnit { get; set; }
        [Aggregated] public virtual IList<Question> Questions { get; set; }
        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string TopicNotes { get; set; }
    }
}