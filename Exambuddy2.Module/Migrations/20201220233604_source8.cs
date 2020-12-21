using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class source8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_FileDataAnswers_FileId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_FileDataQuestions_FileId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sources_FileDataSources_FileId",
                table: "Sources");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Sources",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Answers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_FileDataAnswers_FileId",
                table: "Answers",
                column: "FileId",
                principalTable: "FileDataAnswers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_FileDataQuestions_FileId",
                table: "Questions",
                column: "FileId",
                principalTable: "FileDataQuestions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_FileDataSources_FileId",
                table: "Sources",
                column: "FileId",
                principalTable: "FileDataSources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_FileDataAnswers_FileId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_FileDataQuestions_FileId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sources_FileDataSources_FileId",
                table: "Sources");

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Sources",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FileId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_FileDataAnswers_FileId",
                table: "Answers",
                column: "FileId",
                principalTable: "FileDataAnswers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_FileDataQuestions_FileId",
                table: "Questions",
                column: "FileId",
                principalTable: "FileDataQuestions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_FileDataSources_FileId",
                table: "Sources",
                column: "FileId",
                principalTable: "FileDataSources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
