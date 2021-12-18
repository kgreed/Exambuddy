using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Exambuddy2.Module.Annotations;
using Exambuddy2.Module.BusinessObjects;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    [FileAttachment(nameof(DataFile))]
    [DefaultClassOptions]
    [ImageName("BO_Resume")]
    public class Question : BasicBo //, INotifyPropertyChanged// contains IObjectSpaceLink
    {
        public Question()
        {
            Answers = new List<Answer>();
            Comments = new List<QuestionComment>();
        }

        public override BasicBo Parent
        {
            get => Source;
            set
            {
                var bo = value;
                Source = bo.ObjectSpace.FindObject<Source>(CriteriaOperator.Parse("[Id]=? ", bo.Id));
            }
        }
        [RuleRequiredField(DefaultContexts.Save)]
        public string Name { get; set; }
        public string QuestionNo { get; set; }
        [Browsable(false)] public int SourceId { get; set; }
        [RuleRequiredField(DefaultContexts.Save)]
        [ForeignKey("SourceId")] public virtual Source Source { get; set; }
        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string QuestionText { get; set; }
        
        public virtual IList<Answer> Answers { get; set; }
        public virtual IList<QuestionComment> Comments { get; set; }
        [Browsable(false)] public int? FileId { get; set; }
        [ForeignKey("FileId")]
        [Aggregated]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        [VisibleInListView(false)]
        public virtual QuestionFileData DataFile { get; set; }
        //[Size(-1)]
        //[Delayed(true)]
        [NotMapped]
        [ImageEditor]
        // [VisibleInListView(false)]
        public byte[] Photo
        {
            get => DataFile?.Content;
            set
            {
                var df = ObjectSpace.FindObject<QuestionFileData>(CriteriaOperator.Parse("[Id]=? ", FileId));
                if (df == null) DataFile ??= new QuestionFileData();
                if (DataFile == null) throw new Exception("DataFile is null even though it exists");
                DataFile.Content = value;
            }
        }

        public override void AddChild(BasicBo child)
        {
            base.AddChild(child);
            switch (child)
            {
                case Answer ans:
                    Answers.Add(ans);
                    break;
                case QuestionComment qc:
                    Comments.Add(qc);
                    break;
            }
        }
       
        //public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}