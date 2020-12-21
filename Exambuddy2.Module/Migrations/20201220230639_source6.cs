using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class source6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Sources",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Sources",
                newName: "Description");
        }
    }
}
