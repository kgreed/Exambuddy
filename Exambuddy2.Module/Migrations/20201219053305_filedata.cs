using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class filedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileData_Questions_QuestionId",
                table: "FileData");

            migrationBuilder.DropIndex(
                name: "IX_FileData_QuestionId",
                table: "FileData");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "FileData");

            migrationBuilder.AddColumn<int>(
                name: "FileID",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_FileID",
                table: "Questions",
                column: "FileID");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_FileData_FileID",
                table: "Questions",
                column: "FileID",
                principalTable: "FileData",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_FileData_FileID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_FileID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "FileID",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "FileData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileData_QuestionId",
                table: "FileData",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FileData_Questions_QuestionId",
                table: "FileData",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
