using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class temporal5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                       AddTemporalTableSupport(migrationBuilder, "QuestionComments", "History");
                      AddTemporalTableSupport(migrationBuilder, "QuestionCommentCategories", "History");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
        public static void AddTemporalTableSupport(MigrationBuilder builder,
            string tableName, string historyTableSchema)
        {
            builder.Sql($@"ALTER TABLE {tableName} ADD 
                            SysStartTime datetime2(0) GENERATED ALWAYS AS ROW START HIDDEN NOT NULL,
                            SysEndTime datetime2(0) GENERATED ALWAYS AS ROW END HIDDEN NOT NULL,
                            PERIOD FOR SYSTEM_TIME (SysStartTime, SysEndTime);");
            builder.Sql($@"ALTER TABLE {tableName} 
                SET (SYSTEM_VERSIONING = ON (HISTORY_TABLE = {historyTableSchema}.{tableName} ));");
        }
    }
}
 
