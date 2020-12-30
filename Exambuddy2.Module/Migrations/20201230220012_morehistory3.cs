using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class morehistory3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       
            temporal.AddTemporalTableSupport(migrationBuilder, "FileDataQuestions", "History");
            temporal.AddTemporalTableSupport(migrationBuilder, "AnswerCommentCategories", "History");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
