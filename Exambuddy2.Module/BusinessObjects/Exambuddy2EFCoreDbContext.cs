﻿using DevExpress.ExpressApp.Design;
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
        
        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);


            mb.Entity<Topic>().HasOne(b => b.CourseUnit).WithMany(i => i.Topics);
            mb.Entity<Source>().HasOne(b => b.Topic).WithMany(i => i.Sources);
            mb.Entity<Question>().HasOne(b => b.Source).WithMany(i => i.Questions);

            mb.Entity<Answer>().HasOne(b => b.Question).WithMany(i => i.Answers);
            //mb.Entity<Question>().HasMany(b=>b.Answers).WithOne(x=>x.Question).OnDelete(DeleteBehavior.NoAction);


        }
    }
    
}