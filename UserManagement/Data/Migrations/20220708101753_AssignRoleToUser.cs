using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Data.Migrations
{
    public partial class AssignRoleToUser : Migration
    {
        protected override void Up(MigrationBuilder builder)
        {
            builder.Sql("insert into [security].[userRoles] (UserId,RoleId) SELECT '8a835b42-dafc-4247-a4a3-9683b300fc51',id from [security].[roles]");
        }

        protected override void Down(MigrationBuilder builder)
        {
            builder.Sql("DELETE from [security].[userRoles] where UserId='8a835b42-dafc-4247-a4a3-9683b300fc51'");
        }
    }
}
