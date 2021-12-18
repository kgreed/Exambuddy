using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.BaseImpl.EF;
namespace Exambuddy2.Module.BusinessObjects
{
    [Table("FileDataCards")]
    public class CardFileData : FileData
    {
        //[Browsable(false)]
        //public int QuestionId { get; set; }
        //[ForeignKey("QuestionId")]
        //public virtual Question Question { get; set; }
    }
}