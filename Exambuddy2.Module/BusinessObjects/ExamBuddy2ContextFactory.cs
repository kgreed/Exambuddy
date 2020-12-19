using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Exambuddy2.Module.BusinessObjects
{
    public class ExamBuddy2ContextFactory : IDesignTimeDbContextFactory<Exambuddy2EFCoreDbContext>
    {
        public Exambuddy2EFCoreDbContext CreateDbContext(string[] args)
        {

			

            var optionsBuilder = new DbContextOptionsBuilder<Exambuddy2EFCoreDbContext>().UseSqlServer("Trusted_Connection=False;Pooling=false;Data Source=plesk-win-02.expeed.com.au,8484;Initial Catalog=ExamBuddy2;User Id=ebud2;Password=Ld8p59_n");
            return new Exambuddy2EFCoreDbContext(optionsBuilder.Options);
        }
    }
}