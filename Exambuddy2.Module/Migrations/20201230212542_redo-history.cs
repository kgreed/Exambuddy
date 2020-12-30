using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class redohistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("CREATE SCHEMA History");
            temporal.AddTemporalTableSupport(migrationBuilder, "Questions", "History");
            temporal.AddTemporalTableSupport(migrationBuilder, "Answers", "History");
           


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
        
    }
}
