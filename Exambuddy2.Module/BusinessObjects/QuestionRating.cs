using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
namespace Exambuddy2.Module.BusinessObjects
{
    public class QuestionRating : BasicBo
    {
        [Browsable(false)]
        [Required]
        public int QuestonId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }

        [Browsable(false)]
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual PermissionPolicyUser User { get; set; }

        [Browsable(false)]
        [Required]
        public int AwardToUserId { get; set; }
        [ForeignKey("AwardToUserId")]
        public virtual PermissionPolicyUser AwardToUser { get; set; }

        public  int ScoreType { get; set; }
        [NotMapped] public ScoreTypeEnum scoreTypeEnum { get; set; }
        public int Score { get; set; }

    }
    public enum ScoreTypeEnum
    {
        DifficultyRating =1,
        ProficiencyRating =2, 
        BonusOffered =3,
        BonusAwarded =4

    }
}