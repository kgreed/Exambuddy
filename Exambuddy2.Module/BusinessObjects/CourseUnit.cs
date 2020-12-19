using System.Collections.Generic;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    public class CourseUnit :BasicBo
    {
        public CourseUnit()
        {
            this.Topics = new List<Topic>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [Aggregated]
        public virtual ICollection<Topic> Topics { get; set; }
    }
}