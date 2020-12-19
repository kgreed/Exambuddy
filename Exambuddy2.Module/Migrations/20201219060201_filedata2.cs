using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class filedata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelatedFile_FileData_FileId",
                table: "RelatedFile");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedFile_Questions_QuestionId",
                table: "RelatedFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelatedFile",
                table: "RelatedFile");

            migrationBuilder.DropIndex(
                name: "IX_RelatedFile_QuestionId",
                table: "RelatedFile");

            migrationBuilder.RenameTable(
                name: "RelatedFile",
                newName: "RelatedFiles");

            migrationBuilder.RenameIndex(
                name: "IX_RelatedFile_FileId",
                table: "RelatedFiles",
                newName: "IX_RelatedFiles_FileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelatedFiles",
                table: "RelatedFiles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedFiles_QuestionId",
                table: "RelatedFiles",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedFiles_FileData_FileId",
                table: "RelatedFiles",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedFiles_Questions_QuestionId",
                table: "RelatedFiles",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelatedFiles_FileData_FileId",
                table: "RelatedFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedFiles_Questions_QuestionId",
                table: "RelatedFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelatedFiles",
                table: "RelatedFiles");

            migrationBuilder.DropIndex(
                name: "IX_RelatedFiles_QuestionId",
                table: "RelatedFiles");

            migrationBuilder.RenameTable(
                name: "RelatedFiles",
                newName: "RelatedFile");

            migrationBuilder.RenameIndex(
                name: "IX_RelatedFiles_FileId",
                table: "RelatedFile",
                newName: "IX_RelatedFile_FileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelatedFile",
                table: "RelatedFile",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedFile_QuestionId",
                table: "RelatedFile",
                column: "QuestionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedFile_FileData_FileId",
                table: "RelatedFile",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedFile_Questions_QuestionId",
                table: "RelatedFile",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
