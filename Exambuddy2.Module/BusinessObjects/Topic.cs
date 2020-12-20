using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    public class Topic :BasicBo 
    {
        public Topic()
        {
            Questions = new HashSet<Question>();
        }

        public override BasicBo Parent
        {
            get => CourseUnit as BasicBo;
            set
            {
                var bo = value;
                var attachedBo =bo.ObjectSpace.FindObject<CourseUnit>(bo.Id);
                CourseUnit =attachedBo;
            }
        }
        
        public string Name { get; set; }
        [Browsable(false)]
        public  int CourseUnitId { get; set; }
        [ForeignKey("CourseUnitId")]
        public virtual CourseUnit CourseUnit { get; set; }

        [Aggregated]
        public virtual ICollection<Question> Questions { get; set; }

         
        [EditorAlias("MyHtmlPropertyEditor"), ModelDefault("RowCount", "4")]
        public string TopicNotes { get; set; }
         
    }
}