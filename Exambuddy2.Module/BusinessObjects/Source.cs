using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    [DefaultClassOptions]
    [FileAttachment(nameof(DataFile))]
    public class Source : BasicBo
    {
        public Source()
        {
            Questions = new List<Question>();
        }

        [Browsable(false)] public int TopicId { get; set; }
        [ForeignKey("TopicId")] public virtual Topic Topic { get; set; }
        [MaxLength(255)] public string Name { get; set; }
        
        public SourceType Type { get; set; }
      
        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string Information { get; set; }
        public virtual IList<Question> Questions { get; set; }
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
            set
            {
                var df = ObjectSpace.FindObject<SourceFileData>(CriteriaOperator.Parse("[Id]=? ", FileId));
                if (df == null) DataFile ??= new SourceFileData();
                if (DataFile == null) throw new Exception("DataFile is null even though it exists");
                DataFile.Content = value;
            }
        }
        public override BasicBo Parent
        {
            get => Topic;
            set
            {
                var bo = value;
                Topic = bo.ObjectSpace.FindObject<Topic>(CriteriaOperator.Parse("[Id]=? ", bo.Id));
            }
        }

        public override void AddChild(BasicBo child)
        {
            base.AddChild(child);
            Questions.Add(child as Question);
        }
    }
}