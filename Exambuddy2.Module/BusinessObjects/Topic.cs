using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    public class Topic :BasicBo
    {
        public Topic()
        {
            Questions = new List<Question>();
        }

        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Browsable(false)]
        public  int CourseUnitId { get; set; }
        [ForeignKey("CourseUnitId")]
        public virtual CourseUnit CourseUnit { get; set; }

        [Aggregated]
        public virtual ICollection<Question> Questions { get; set; }
    }
}