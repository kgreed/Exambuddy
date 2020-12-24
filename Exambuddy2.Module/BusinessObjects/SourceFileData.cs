using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.BaseImpl.EF;
namespace Exambuddy2.Module.BusinessObjects
{
    [Table("FileDataSources")]
    public class SourceFileData : FileData
    {
         //[Browsable(false)]
         //public int SourceId { get; set; }
         //[ForeignKey("SourceId")]
         //public virtual Source Source { get; set; }
    }
}