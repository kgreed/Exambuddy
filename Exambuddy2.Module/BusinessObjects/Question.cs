using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Text.Interop;
using DevExpress.XtraRichEdit.Layout;
using Exambuddy2.Module.Annotations;
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
            DataFile = new QuestionFileData();
            
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

        private string _name { get; set; }
        //[ImmediatePostData]
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
               // OnPropertyChanged();

            }
        }
        [ImmediatePostData]
        public string QuestionNo { get; set; }



        [Browsable(false)]
        public int SourceId { get; set; }
        [ForeignKey("SourceId")]
        public virtual Source Source { get; set; }
        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        [ImmediatePostData]
        public string QuestionText { get; set; }

        public string Tags { get; set; }
        [DevExpress.ExpressApp.DC.Aggregated] public virtual IList<Answer> Answers { get; set; }

        [DevExpress.ExpressApp.DC.Aggregated] public virtual IList<QuestionComment> Comments { get; set; }
        [Browsable(false)] public int? FileId { get; set; }
        [ForeignKey("FileId")]
        [Required]
        [DevExpress.ExpressApp.DC.Aggregated]
        [ExpandObjectMembers(ExpandObjectMembers.Never)]
        [VisibleInListView(false)]
        public virtual QuestionFileData DataFile { get; set; }
        //[Size(-1)]
        //[Delayed(true)]
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
            Answers.Add(child as Answer);
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}