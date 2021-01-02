using Exambuddy2.Module.Functions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Exambuddy2.Module.BusinessObjects
{
    public class ExamBuddy2ContextFactory : IDesignTimeDbContextFactory<Exambuddy2EFCoreDbContext>
    {
        public Exambuddy2EFCoreDbContext CreateDbContext(string[] args)
        {
            var connectionString = HandyFunctions.GetConnectionString();	 
            var optionsBuilder = new DbContextOptionsBuilder<Exambuddy2EFCoreDbContext>().UseSqlServer( connectionString);
            return new Exambuddy2EFCoreDbContext(optionsBuilder.Options);
        }
    }
}