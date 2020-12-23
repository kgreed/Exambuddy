using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class restructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Sources_SourceId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sources_FileDataSources_FileId",
                table: "Sources");

            //migrationBuilder.DropTable(
            //    name: "TagLink");

            //migrationBuilder.DropTable(
            //    name: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Sources_FileId",
                table: "Sources");

            migrationBuilder.DropIndex(
                name: "IX_Questions_SourceId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TopicId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "DataFileID",
                table: "Sources",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Sources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sources_DataFileID",
                table: "Sources",
                column: "DataFileID");

            migrationBuilder.CreateIndex(
                name: "IX_Sources_TopicId",
                table: "Sources",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Sources_FileId",
                table: "Questions",
                column: "FileId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_FileDataSources_DataFileID",
                table: "Sources",
                column: "DataFileID",
                principalTable: "FileDataSources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_Topics_TopicId",
                table: "Sources",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Sources_FileId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sources_FileDataSources_DataFileID",
                table: "Sources");

            migrationBuilder.DropForeignKey(
                name: "FK_Sources_Topics_TopicId",
                table: "Sources");

            migrationBuilder.DropIndex(
                name: "IX_Sources_DataFileID",
                table: "Sources");

            migrationBuilder.DropIndex(
                name: "IX_Sources_TopicId",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "DataFileID",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    TagId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagLink_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagLink_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TagLink_Tags_TagId1",
                        column: x => x.TagId1,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sources_FileId",
                table: "Sources",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SourceId",
                table: "Questions",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_TagLink_QuestionId",
                table: "TagLink",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_TagLink_TagId",
                table: "TagLink",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_TagLink_TagId1",
                table: "TagLink",
                column: "TagId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Sources_SourceId",
                table: "Questions",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sources_FileDataSources_FileId",
                table: "Sources",
                column: "FileId",
                principalTable: "FileDataSources",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
