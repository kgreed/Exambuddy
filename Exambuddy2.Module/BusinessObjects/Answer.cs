using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
//using DevExpress.Xpo;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]

    [FileAttachment(nameof(DataFile))]
    [DefaultClassOptions, ImageName("BO_Resume")]
    public class Answer :BasicBo
    {
        public Answer()
        {
            DataFile = new AnswerFileData();
        }
        public override BasicBo Parent
        {
            get => Question;
            set
            {
                var bo = value;
                Question = bo.ObjectSpace.FindObject<Question>(CriteriaOperator.Parse("[Id]=? ", bo.Id));
            }
        }
        public  DateTime uncStartTime { get; set; }
        public DateTime uncEndTime { get; set; }

        [Browsable(false)]
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        [Required]
        public virtual Question Question { get; set; }


        [EditorAlias("MyHtmlPropertyEditor"), ModelDefault("RowCount", "4")]
        public string AnswerText { get; set; }

        [Browsable(false)]
        public int? FileId { get; set; }
        [ForeignKey("FileId")]
        [Required]
        [Aggregated, ExpandObjectMembers(ExpandObjectMembers.Never)]
        public virtual AnswerFileData DataFile { get; set; }


        //[Size(-1)]
        //[Delayed(true)]
        [NotMapped]
        [ImageEditor]
        public byte[] Photo { get => DataFile?.Content; set => DataFile.Content = value; }

        [Browsable(false)]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual PermissionPolicyUser User { get; set; }

    }
}