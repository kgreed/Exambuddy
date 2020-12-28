using DevExpress.Persistent.Base;
namespace Exambuddy2.Module.BusinessObjects
{
    [NavigationItem("Main")]
    [DefaultClassOptions]
    [ImageName("BO_Resume")]
    public class AnswerCommentCategory : BasicBo
    {
        public string Name { get; set; }
    }
}