using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class category4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComments_Questions_QuestionId",
                table: "QuestionComments");

            migrationBuilder.DropColumn(
                name: "QuestonId",
                table: "QuestionComments");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "QuestionComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComments_Questions_QuestionId",
                table: "QuestionComments",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionComments_Questions_QuestionId",
                table: "QuestionComments");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "QuestionComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "QuestonId",
                table: "QuestionComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionComments_Questions_QuestionId",
                table: "QuestionComments",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
