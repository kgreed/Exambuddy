using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.Validation;
namespace Exambuddy2.Module.BusinessObjects
{
   [Table("QuestionComments")]
    
    public class QuestionComment : BasicBo
    {
        public QuestionComment()
        {
             Score = 0;
        }

        [Browsable(false)]
       
        public int QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        [RuleRequiredField(DefaultContexts.Save)]
        public virtual Question Question { get; set; }

        [Browsable(false)]
        public string Name => $"{Question?.QuestionNo} {Text}";

        [EditorAlias("MyHtmlPropertyEditor")]
        [ModelDefault("RowCount", "4")]
        public string  Text { get; set; }

 
        [Browsable(false)]
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [RuleRequiredField(DefaultContexts.Save)]
        public virtual QuestionCommentCategory Category { get; set; }
        public int Score { get; set; }

        public override BasicBo Parent
        {
            get => Question;
            set
            {
                var bo = value;
                Question = bo.ObjectSpace.FindObject<Question>(CriteriaOperator.Parse("[Id]=? ", bo.Id));
            }
        }

      

    }
}