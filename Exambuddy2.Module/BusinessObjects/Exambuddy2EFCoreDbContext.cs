using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using Microsoft.EntityFrameworkCore;
namespace Exambuddy2.Module.BusinessObjects
{
    [TypesInfoInitializer(typeof(Exambuddy2ContextInitializer))]
    public class Exambuddy2EFCoreDbContext : DbContext
    {
        public Exambuddy2EFCoreDbContext(DbContextOptions<Exambuddy2EFCoreDbContext> options) : base(options)
        {
        }

        public DbSet<ModuleInfo> ModulesInfo { get; set; }
        public DbSet<ModelDifference> ModelDifferences { get; set; }
        public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
        public DbSet<PermissionPolicyRole> Roles { get; set; }
        public DbSet<PermissionPolicyUser> Users { get; set; }
     
        public DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<CourseUnit> CourseUnits { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerFileData> AnswerFileData { get; set; }
        public DbSet<QuestionFileData> QuestionFileData { get; set; }
        public DbSet<SourceFileData> SourceFileData { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<QuestionCommentCategory> QuestionCommentCategories { get; set; }
        public DbSet<AnswerCommentCategory> AnswerCommentCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Entity<Topic>().HasOne(b => b.CourseUnit).WithMany(i => i.Topics);
            mb.Entity<Source>().HasOne(b => b.Topic).WithMany(i => i.Sources);
            mb.Entity<Question>().HasOne(b => b.Source).WithMany(i => i.Questions);
            mb.Entity<QuestionComment>().HasOne(b => b.Question).WithMany(i => i.Comments);
            mb.Entity<QuestionComment>().HasOne(b => b.Category);
            mb.Entity<AnswerComment>().HasOne(b => b.Answer).WithMany(i => i.Comments);
            mb.Entity<QuestionComment>().HasOne(b => b.Category);
            mb.Entity<Answer>().HasOne(b => b.Question).WithMany(i => i.Answers);

        }

    }
}