using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.Validation;
namespace Exambuddy2.Module.BusinessObjects
{
    [Table("AnswerComments")]
    [DefaultProperty("Text")]
    public class AnswerComment : BasicBo
    {
        [Browsable(false)]
        [Required]
        public int AnswerId { get; set; }
        [ForeignKey("AnswerId")]
        [RuleRequiredField(DefaultContexts.Save)]
        public virtual Answer Answer { get; set; }

        [Browsable(false)]
        public string Name => $"{Text}";


        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string  Text { get; set; }

        
        [Browsable(false)]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [RuleRequiredField(DefaultContexts.Save)]
        public virtual AnswerCommentCategpry Category { get; set; }
        public int Score { get; set; }

    }
}