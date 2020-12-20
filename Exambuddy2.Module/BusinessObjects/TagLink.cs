using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    public class TagLink : BasicBo
    {
         
        [Browsable(false)]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        [Aggregated]
        public virtual Question Question { get; set; }
        [Browsable(false)]
        public int TagId { get; set; }
        [ForeignKey("TagId")]
        [Aggregated]
        public virtual Tag Tag { get; set; }
    }
}