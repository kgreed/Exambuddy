using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class source4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SourceId",
                table: "Questions",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Sources_SourceId",
                table: "Questions",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Sources_SourceId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_SourceId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "Questions");
        }
    }
}
