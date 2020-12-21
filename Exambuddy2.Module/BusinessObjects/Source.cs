using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    [DefaultClassOptions]
    public class Source : BasicBo
    {
        [MaxLength(255)]
        public string Name { get; set; }
       
        public SourceType Type { get; set; }
        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string Information { get; set; }

        [Browsable(false)] public int? FileId { get; set; }
        [ForeignKey("FileId")]
       
        [Aggregated]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        [VisibleInListView(false)]
        public virtual SourceFileData DataFile { get; set; }
        [Size(-1)]
        [Delayed(true)]
        [NotMapped]
        [ImageEditor]
        [VisibleInListView(false)]
        public byte[] Photo
        {
            get => DataFile?.Content;
            set => DataFile.Content = value;
        }
    }
}