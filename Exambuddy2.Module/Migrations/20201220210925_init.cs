using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Exambuddy2.Module.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "CourseUnits",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CourseUnits", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FileData",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Size = table.Column<int>(type: "int", nullable: false),
            //        FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Content = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FileData", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ModelDifferences",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ContextId = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Version = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ModelDifferences", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ModulesInfo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        AssemblyFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsMain = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ModulesInfo", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PermissionPolicyRoleBase",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsAdministrative = table.Column<bool>(type: "bit", nullable: false),
            //        CanEditModel = table.Column<bool>(type: "bit", nullable: false),
            //        PermissionPolicy = table.Column<int>(type: "int", nullable: false),
            //        IsAllowPermissionPriority = table.Column<bool>(type: "bit", nullable: false),
            //        Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PermissionPolicyRoleBase", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ReportDataV2",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DataTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsInplaceReport = table.Column<bool>(type: "bit", nullable: false),
            //        PredefinedReportTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Content = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ParametersObjectTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ReportDataV2", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Tags",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tags", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsActive = table.Column<bool>(type: "bit", nullable: false),
            //        ChangePasswordOnFirstLogon = table.Column<bool>(type: "bit", nullable: false),
            //        StoredPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Topics",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CourseUnitId = table.Column<int>(type: "int", nullable: false),
            //        TopicNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Topics", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Topics_CourseUnits_CourseUnitId",
            //            column: x => x.CourseUnitId,
            //            principalTable: "CourseUnits",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ModelDifferenceAspects",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Xml = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        OwnerID = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ModelDifferenceAspects", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_ModelDifferenceAspects_ModelDifferences_OwnerID",
            //            column: x => x.OwnerID,
            //            principalTable: "ModelDifferences",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PermissionPolicyActionPermissionObject",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleID = table.Column<int>(type: "int", nullable: true),
            //        ActionId = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PermissionPolicyActionPermissionObject", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_PermissionPolicyActionPermissionObject_PermissionPolicyRoleBase_RoleID",
            //            column: x => x.RoleID,
            //            principalTable: "PermissionPolicyRoleBase",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PermissionPolicyNavigationPermissionObject",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleID = table.Column<int>(type: "int", nullable: true),
            //        ItemPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        TargetTypeFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NavigateState = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PermissionPolicyNavigationPermissionObject", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_PermissionPolicyNavigationPermissionObject_PermissionPolicyRoleBase_RoleID",
            //            column: x => x.RoleID,
            //            principalTable: "PermissionPolicyRoleBase",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PermissionPolicyTypePermissionObject",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TargetTypeFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        RoleID = table.Column<int>(type: "int", nullable: true),
            //        ReadState = table.Column<int>(type: "int", nullable: true),
            //        WriteState = table.Column<int>(type: "int", nullable: true),
            //        CreateState = table.Column<int>(type: "int", nullable: true),
            //        DeleteState = table.Column<int>(type: "int", nullable: true),
            //        NavigateState = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PermissionPolicyTypePermissionObject", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_PermissionPolicyTypePermissionObject_PermissionPolicyRoleBase_RoleID",
            //            column: x => x.RoleID,
            //            principalTable: "PermissionPolicyRoleBase",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PermissionPolicyRolePermissionPolicyUser",
            //    columns: table => new
            //    {
            //        RolesID = table.Column<int>(type: "int", nullable: false),
            //        UsersID = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PermissionPolicyRolePermissionPolicyUser", x => new { x.RolesID, x.UsersID });
            //        table.ForeignKey(
            //            name: "FK_PermissionPolicyRolePermissionPolicyUser_PermissionPolicyRoleBase_RolesID",
            //            column: x => x.RolesID,
            //            principalTable: "PermissionPolicyRoleBase",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_PermissionPolicyRolePermissionPolicyUser_Users_UsersID",
            //            column: x => x.UsersID,
            //            principalTable: "Users",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Questions",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        TopicId = table.Column<int>(type: "int", nullable: false),
            //        QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        FileId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Questions", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Questions_FileData_FileId",
            //            column: x => x.FileId,
            //            principalTable: "FileData",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Questions_Topics_TopicId",
            //            column: x => x.TopicId,
            //            principalTable: "Topics",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PermissionPolicyMemberPermissionsObject",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Members = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Criteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ReadState = table.Column<int>(type: "int", nullable: true),
            //        WriteState = table.Column<int>(type: "int", nullable: true),
            //        TypePermissionObjectID = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PermissionPolicyMemberPermissionsObject", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_PermissionPolicyMemberPermissionsObject_PermissionPolicyTypePermissionObject_TypePermissionObjectID",
            //            column: x => x.TypePermissionObjectID,
            //            principalTable: "PermissionPolicyTypePermissionObject",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PermissionPolicyObjectPermissionsObject",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Criteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ReadState = table.Column<int>(type: "int", nullable: true),
            //        WriteState = table.Column<int>(type: "int", nullable: true),
            //        DeleteState = table.Column<int>(type: "int", nullable: true),
            //        NavigateState = table.Column<int>(type: "int", nullable: true),
            //        TypePermissionObjectID = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PermissionPolicyObjectPermissionsObject", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_PermissionPolicyObjectPermissionsObject_PermissionPolicyTypePermissionObject_TypePermissionObjectID",
            //            column: x => x.TypePermissionObjectID,
            //            principalTable: "PermissionPolicyTypePermissionObject",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Answers",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        uncStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        uncEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        QuestionId = table.Column<int>(type: "int", nullable: false),
            //        AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        FileId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Answers", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Answers_FileData_FileId",
            //            column: x => x.FileId,
            //            principalTable: "FileData",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Answers_Questions_QuestionId",
            //            column: x => x.QuestionId,
            //            principalTable: "Questions",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TagLink",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        QuestionId = table.Column<int>(type: "int", nullable: false),
            //        TagId = table.Column<int>(type: "int", nullable: false),
            //        TagId1 = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TagLink", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_TagLink_Questions_QuestionId",
            //            column: x => x.QuestionId,
            //            principalTable: "Questions",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_TagLink_Tags_TagId",
            //            column: x => x.TagId,
            //            principalTable: "Tags",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_TagLink_Tags_TagId1",
            //            column: x => x.TagId1,
            //            principalTable: "Tags",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Answers_FileId",
            //    table: "Answers",
            //    column: "FileId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Answers_QuestionId",
            //    table: "Answers",
            //    column: "QuestionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ModelDifferenceAspects_OwnerID",
            //    table: "ModelDifferenceAspects",
            //    column: "OwnerID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PermissionPolicyActionPermissionObject_RoleID",
            //    table: "PermissionPolicyActionPermissionObject",
            //    column: "RoleID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PermissionPolicyMemberPermissionsObject_TypePermissionObjectID",
            //    table: "PermissionPolicyMemberPermissionsObject",
            //    column: "TypePermissionObjectID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PermissionPolicyNavigationPermissionObject_RoleID",
            //    table: "PermissionPolicyNavigationPermissionObject",
            //    column: "RoleID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PermissionPolicyObjectPermissionsObject_TypePermissionObjectID",
            //    table: "PermissionPolicyObjectPermissionsObject",
            //    column: "TypePermissionObjectID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PermissionPolicyRolePermissionPolicyUser_UsersID",
            //    table: "PermissionPolicyRolePermissionPolicyUser",
            //    column: "UsersID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PermissionPolicyTypePermissionObject_RoleID",
            //    table: "PermissionPolicyTypePermissionObject",
            //    column: "RoleID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questions_FileId",
            //    table: "Questions",
            //    column: "FileId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questions_TopicId",
            //    table: "Questions",
            //    column: "TopicId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TagLink_QuestionId",
            //    table: "TagLink",
            //    column: "QuestionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TagLink_TagId",
            //    table: "TagLink",
            //    column: "TagId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_TagLink_TagId1",
            //    table: "TagLink",
            //    column: "TagId1");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Topics_CourseUnitId",
            //    table: "Topics",
            //    column: "CourseUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "ModelDifferenceAspects");

            migrationBuilder.DropTable(
                name: "ModulesInfo");

            migrationBuilder.DropTable(
                name: "PermissionPolicyActionPermissionObject");

            migrationBuilder.DropTable(
                name: "PermissionPolicyMemberPermissionsObject");

            migrationBuilder.DropTable(
                name: "PermissionPolicyNavigationPermissionObject");

            migrationBuilder.DropTable(
                name: "PermissionPolicyObjectPermissionsObject");

            migrationBuilder.DropTable(
                name: "PermissionPolicyRolePermissionPolicyUser");

            migrationBuilder.DropTable(
                name: "ReportDataV2");

            migrationBuilder.DropTable(
                name: "TagLink");

            migrationBuilder.DropTable(
                name: "ModelDifferences");

            migrationBuilder.DropTable(
                name: "PermissionPolicyTypePermissionObject");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "PermissionPolicyRoleBase");

            migrationBuilder.DropTable(
                name: "FileData");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "CourseUnits");
        }
    }
}
