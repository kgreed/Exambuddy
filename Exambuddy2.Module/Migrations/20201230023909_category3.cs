using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class category3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComments_QuestionCommentCategories_CategoryId",
                table: "QuestionComments");

            migrationBuilder.DropIndex(
                name: "IX_QuestionComments_CategoryId",
                table: "QuestionComments");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "QuestionComments");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "QuestionComments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "QuestionComments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "QuestionComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionComments_CategoryId",
                table: "QuestionComments",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComments_QuestionCommentCategories_CategoryId",
                table: "QuestionComments",
                column: "CategoryId",
                principalTable: "QuestionCommentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
