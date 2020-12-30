using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("09 Config")]
    [DefaultClassOptions]
    
    [ImageName("BO_Resume")]
    [Table("AnswerCommentCategories")]
    public class AnsCommentCat : BasicBo
    {
        public string Name { get; set; }
    }
}