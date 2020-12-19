using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    [FileAttachment(nameof(DataFile))]
    public class RelatedFile
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Required]
        [Browsable(false)]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
        [Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)]
        [Browsable(false)]
        public int FileId { get; set; }
        [ForeignKey("FileId")]
        [Required]
        public virtual FileData DataFile { get; set; }


        [Size(-1)]
        [Delayed(true)]
        [NotMapped]
        [ImageEditor]
        public byte[] Photo { get => DataFile?.Content; set => DataFile.Content = value; }
    }
}