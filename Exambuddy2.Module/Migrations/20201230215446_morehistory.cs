using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class morehistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            temporal.AddTemporalTableSupport(migrationBuilder, "Sources", "History");
            temporal.AddTemporalTableSupport(migrationBuilder, "Topics", "History");
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
