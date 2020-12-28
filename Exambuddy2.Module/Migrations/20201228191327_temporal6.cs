using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class temporal6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            temporal5.AddTemporalTableSupport( migrationBuilder, "AnswerComments", "History");
            temporal5.AddTemporalTableSupport(migrationBuilder, "AnswerCommentCategories", "History");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
