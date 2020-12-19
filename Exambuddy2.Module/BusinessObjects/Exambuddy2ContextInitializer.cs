using System;
using System.Collections;
using DevExpress.DataAccess.Native.DataFederation.QueryBuilder;
using Microsoft.EntityFrameworkCore;
using DevExpress.ExpressApp.EFCore.DesignTime;
namespace Exambuddy2.Module.BusinessObjects {
    // This code allows our Model Editor to get relevant EF Core metadata at design time.
    // For details, please refer to https://supportcenter.devexpress.com/internal/ticket/details/t933891.
	public class Exambuddy2ContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			var builder = new DbContextOptionsBuilder<Exambuddy2EFCoreDbContext>()
                .UseSqlServer(@";");
            return new Exambuddy2EFCoreDbContext(builder.Options);
		}
	}
}
