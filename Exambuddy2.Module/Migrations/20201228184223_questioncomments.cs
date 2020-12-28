using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class questioncomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComment_QuestionCommentCategories_CategoryId",
                table: "QuestionComment");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComment_Questions_QuestionId",
                table: "QuestionComment");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComment_Users_UserId",
                table: "QuestionComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionComment",
                table: "QuestionComment");

            migrationBuilder.RenameTable(
                name: "QuestionComment",
                newName: "QuestionComments");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionComment_UserId",
                table: "QuestionComments",
                newName: "IX_QuestionComments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionComment_QuestionId",
                table: "QuestionComments",
                newName: "IX_QuestionComments_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionComment_CategoryId",
                table: "QuestionComments",
                newName: "IX_QuestionComments_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionComments",
                table: "QuestionComments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComments_QuestionCommentCategories_CategoryId",
                table: "QuestionComments",
                column: "CategoryId",
                principalTable: "QuestionCommentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComments_Questions_QuestionId",
                table: "QuestionComments",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComments_Users_UserId",
                table: "QuestionComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComments_QuestionCommentCategories_CategoryId",
                table: "QuestionComments");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComments_Questions_QuestionId",
                table: "QuestionComments");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComments_Users_UserId",
                table: "QuestionComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionComments",
                table: "QuestionComments");

            migrationBuilder.RenameTable(
                name: "QuestionComments",
                newName: "QuestionComment");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionComments_UserId",
                table: "QuestionComment",
                newName: "IX_QuestionComment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionComments_QuestionId",
                table: "QuestionComment",
                newName: "IX_QuestionComment_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionComments_CategoryId",
                table: "QuestionComment",
                newName: "IX_QuestionComment_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionComment",
                table: "QuestionComment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComment_QuestionCommentCategories_CategoryId",
                table: "QuestionComment",
                column: "CategoryId",
                principalTable: "QuestionCommentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComment_Questions_QuestionId",
                table: "QuestionComment",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComment_Users_UserId",
                table: "QuestionComment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
