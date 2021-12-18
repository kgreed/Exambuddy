using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class fields3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "text",
                table: "Cards",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "Cards",
                newName: "Subject");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Cards",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);


            temporal.AddTemporalTableSupport(migrationBuilder, "FileDataCard", "History");
            temporal.AddTemporalTableSupport(migrationBuilder, "Cards", "History");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Cards",
                newName: "text");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Cards",
                newName: "subject");

            migrationBuilder.AlterColumn<string>(
                name: "subject",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);
        }
    }
}
