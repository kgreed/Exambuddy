using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class morehistory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         //   temporal.AddTemporalTableSupport(migrationBuilder, "CourseUnits", "History");
         //   temporal.AddTemporalTableSupport(migrationBuilder, "FileDataSources", "History");
          //  temporal.AddTemporalTableSupport(migrationBuilder, "FileDataQuestions", "History");
            temporal.AddTemporalTableSupport(migrationBuilder, "FileDataAnswers", "History");
            temporal.AddTemporalTableSupport(migrationBuilder, "QuestionComments", "History");
            temporal.AddTemporalTableSupport(migrationBuilder, "QuestionCommentCategories", "History");
            temporal.AddTemporalTableSupport(migrationBuilder, "AnswerComments", "History");
           // temporal.AddTemporalTableSupport(migrationBuilder, "AnswerCommentCategories", "History");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
