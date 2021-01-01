using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Config")]
    [DefaultClassOptions]
     
    [ImageName("BO_Resume")]
    [Table("QuestionCommentCategories")]
    public class QuestionCommentCategory : BasicBo
    {
        public string Name { get; set; }
    }
}