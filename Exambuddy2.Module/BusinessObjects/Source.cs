using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
 
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    [DefaultClassOptions]
    public class Source : BasicBo
    {
        public Source()
        {
            Questions = new List<Question>();
            DataFile = new SourceFileData();
        }

        [Browsable(false)]
        public int TopicId { get; set; }
        [ForeignKey("TopicId")]
        [VisibleInDetailView(true)]
        [DevExpress.ExpressApp.Model.Required]
        [Aggregated] public virtual Topic Topic { get; set; } 

        [MaxLength(255)]
        public string Name { get; set; }
       
        public SourceType Type { get; set; }
        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string Information { get; set; }
        [Aggregated] public virtual IList<Question> Questions { get; set; }
        [Browsable(false)] public int? FileId { get; set; }
        [ForeignKey("FileId")]
        [Aggregated]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        [VisibleInListView(false)]
        public virtual SourceFileData DataFile { get; set; }
        
        [NotMapped]
        [ImageEditor]
        [VisibleInListView(false)]
        public byte[] Photo
        {
            get => DataFile?.Content;
            set => DataFile.Content = value;
        }
        public override void AddChild(BasicBo child)
        {
            base.AddChild(child);
            Questions.Add(child as Question);
        }
    }
}