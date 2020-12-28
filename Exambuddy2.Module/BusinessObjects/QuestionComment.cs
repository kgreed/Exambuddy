using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
namespace Exambuddy2.Module.BusinessObjects
{
   [Table("QuestionComments")]
    public class QuestionComment : BasicBo
    {
        [Browsable(false)]
        [Required]
        public int QuestonId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }


        public string Name => Question?.QuestionNo;

        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string RatingText { get; set; }

        [Browsable(false)]
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual PermissionPolicyUser User { get; set; }
        [Browsable(false)]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual QuestionCommentCategory Category { get; set; }
        public int Score { get; set; }

    }
}