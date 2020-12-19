using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class more : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "RelatedFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedFile_FileData_FileId",
                        column: x => x.FileId,
                        principalTable: "FileData",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedFile_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelatedFile_FileId",
                table: "RelatedFile",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedFile_QuestionId",
                table: "RelatedFile",
                column: "QuestionId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelatedFile");

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
    }
}
