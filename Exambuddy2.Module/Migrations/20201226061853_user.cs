using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedOrModifiedByUserId",
                table: "Topics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOrModifiedByUserId",
                table: "Sources",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOrModifiedByUserId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOrModifiedByUserId",
                table: "CourseUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedOrModifiedByUserId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOrModifiedByUserId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CreatedOrModifiedByUserId",
                table: "Sources");

            migrationBuilder.DropColumn(
                name: "CreatedOrModifiedByUserId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CreatedOrModifiedByUserId",
                table: "CourseUnits");

            migrationBuilder.DropColumn(
                name: "CreatedOrModifiedByUserId",
                table: "Answers");
        }
    }
}
