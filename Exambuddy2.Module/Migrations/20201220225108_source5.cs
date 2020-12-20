using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class source5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FileId",
                table: "Sources",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sources_FileId",
                table: "Sources",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_FileData_FileId",
                table: "Sources",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sources_FileData_FileId",
                table: "Sources");

            migrationBuilder.DropIndex(
                name: "IX_Sources_FileId",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "Sources");
        }
    }
}
