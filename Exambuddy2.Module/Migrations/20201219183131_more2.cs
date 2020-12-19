using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class more2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_CourseUnits_CourseUnitId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "AnswerText",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "CourseUnitId",
                table: "Topics",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseUnitId1",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseUnitId2",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId1",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId2",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CourseUnitId1",
                table: "Topics",
                column: "CourseUnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CourseUnitId2",
                table: "Topics",
                column: "CourseUnitId2");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId1",
                table: "Questions",
                column: "TopicId1");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId2",
                table: "Questions",
                column: "TopicId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId1",
                table: "Questions",
                column: "TopicId1",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId2",
                table: "Questions",
                column: "TopicId2",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_CourseUnits_CourseUnitId",
                table: "Topics",
                column: "CourseUnitId",
                principalTable: "CourseUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_CourseUnits_CourseUnitId1",
                table: "Topics",
                column: "CourseUnitId1",
                principalTable: "CourseUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_CourseUnits_CourseUnitId2",
                table: "Topics",
                column: "CourseUnitId2",
                principalTable: "CourseUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId1",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId2",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_CourseUnits_CourseUnitId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_CourseUnits_CourseUnitId1",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_CourseUnits_CourseUnitId2",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_CourseUnitId1",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_CourseUnitId2",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TopicId1",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TopicId2",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CourseUnitId1",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CourseUnitId2",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "TopicId1",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TopicId2",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "CourseUnitId",
                table: "Topics",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "AnswerText",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_CourseUnits_CourseUnitId",
                table: "Topics",
                column: "CourseUnitId",
                principalTable: "CourseUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
