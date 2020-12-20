using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using Microsoft.EntityFrameworkCore;
namespace Exambuddy2.Module.BusinessObjects
{
    [TypesInfoInitializer(typeof(Exambuddy2ContextInitializer))]
    public class Exambuddy2EFCoreDbContext : DbContext {
        public Exambuddy2EFCoreDbContext(DbContextOptions<Exambuddy2EFCoreDbContext> options) : base(options) {
        }
        public DbSet<ModuleInfo> ModulesInfo { get; set; }
        public DbSet<ModelDifference> ModelDifferences { get; set; }
        public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
        public DbSet<PermissionPolicyRole> Roles { get; set; }
        public DbSet<PermissionPolicyUser> Users { get; set; }
        public DbSet<FileData> FileData { get; set; }
        public DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<CourseUnit> CourseUnits { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);


            mb.Entity<Topic>().HasOne(b => b.CourseUnit).WithMany(i => i.Topics);
            mb.Entity<Question>().HasOne(b => b.Topic).WithMany(i => i.Questions);

           // mb.Entity<Question>().HasOne(x => x.Source);
            mb.Entity<Question>().HasMany(b=>b.Answers).WithOne(x=>x.Question).OnDelete(DeleteBehavior.NoAction);
            //mb.Entity<Question>().HasMany<TagLink>().WithOne(x=>x.Question).OnDelete(DeleteBehavior.Cascade);
            mb.Entity<Tag>().HasMany<TagLink>().WithOne(x=>x.Tag).OnDelete(DeleteBehavior.NoAction);
            //mb.Entity<TagLink>().HasOne<Question>().WithMany(b => b.TagLinks);
            //mb.Entity<TagLink>().HasOne<Tag>().WithMany(b => b.TagLinks);
           // mb.Entity<Answer>().HasOne(x => x.Question).WithMany(i=>i.Answers);

        }
    }
    
}