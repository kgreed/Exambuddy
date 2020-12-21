using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class source7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_FileData_FileId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_FileData_FileId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sources_FileData_FileId",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "FileData");

            migrationBuilder.CreateTable(
                name: "FileDataAnswers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDataAnswers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FileDataAnswers_FileData_ID",
                        column: x => x.ID,
                        principalTable: "FileData",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileDataQuestions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDataQuestions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FileDataQuestions_FileData_ID",
                        column: x => x.ID,
                        principalTable: "FileData",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileDataSources",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDataSources", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FileDataSources_FileData_ID",
                        column: x => x.ID,
                        principalTable: "FileData",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.DropTable(
                name: "FileDataAnswers");

            migrationBuilder.DropTable(
                name: "FileDataQuestions");

            migrationBuilder.DropTable(
                name: "FileDataSources");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "FileData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_FileData_FileId",
                table: "Answers",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_FileData_FileId",
                table: "Questions",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_FileData_FileId",
                table: "Sources",
                column: "FileId",
                principalTable: "FileData",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
