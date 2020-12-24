using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.BaseImpl.EF;
namespace Exambuddy2.Module.BusinessObjects
{
    [Table("FileDataAnswers")]
    public class AnswerFileData : FileData
    {
        //[Browsable(false)]
        //public int SourceId { get; set; }
        //[ForeignKey("AnswerId")]
        //public virtual Answer Answer { get; set; }
    }
}