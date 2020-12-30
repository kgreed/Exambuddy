using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class morehistory5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           temporal.AddTemporalTableSupport(migrationBuilder, "CourseUnits", "History");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
