using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class morehistory4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            temporal.AddTemporalTableSupport(migrationBuilder, "FileDataSources", "History");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
