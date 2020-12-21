using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    [FileAttachment(nameof(DataFile))]
    [DefaultClassOptions]
    [ImageName("BO_Resume")]

    public class Question : BasicBo
    {
        public Question()
        {
            Answers = new List<Answer>();
            TagLinks = new List<TagLink>();
           
        }
        [ImmediatePostData]
        public string Name { get; set; }
        [ImmediatePostData]
        public string QuestionNo { get; set; }



        [Browsable(false)]
        public int SourceId { get; set; }
        [ForeignKey("SourceId")]
        public virtual Source Source { get; set; }

        [Browsable(false)] public int TopicId { get; set; }
        [ForeignKey("TopicId")] public virtual Topic Topic { get; set; }
        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        [ImmediatePostData]
        public string QuestionText { get; set; }
        [Aggregated] public virtual IList<Answer> Answers { get; set; }
        [Aggregated] public virtual IList<TagLink> TagLinks { get; set; }
        [Browsable(false)] public int? FileId { get; set; }
        [ForeignKey("FileId")]
        [Required]
        [Aggregated]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        [VisibleInListView(false)]
        public virtual QuestionFileData DataFile { get; set; }
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