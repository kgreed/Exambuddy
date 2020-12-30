using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class removeuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerComments_Users_UserId",
                table: "AnswerComments");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComments_Users_UserId",
                table: "QuestionComments");

            migrationBuilder.DropIndex(
                name: "IX_QuestionComments_UserId",
                table: "QuestionComments");

            migrationBuilder.DropIndex(
                name: "IX_AnswerComments_UserId",
                table: "AnswerComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "QuestionComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AnswerComments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "QuestionComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AnswerComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionComments_UserId",
                table: "QuestionComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerComments_UserId",
                table: "AnswerComments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerComments_Users_UserId",
                table: "AnswerComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComments_Users_UserId",
                table: "QuestionComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
