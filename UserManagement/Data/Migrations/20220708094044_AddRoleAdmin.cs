using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Data.Migrations
{
    public partial class AddRoleAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'8a835b42-dafc-4247-a4a3-9683b300fc51', N'massif.abdessamed.11', N'MASSIF.ABDESSAMED.11', N'massif.abdessamed.11@gmail.com', N'MASSIF.ABDESSAMED.11@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEGVbhHJ8H/p+W7DUrmxjOHOM59tNGs6Dj8GkJJHOORaSyDRYIw9QhXUbynibjEydvg==', N'6Q57DIMPDG2N3R4H6FKLLXSUVM7LMFL2', N'3e0d5764-6c96-4b06-8e7e-7dceda8e578f', N'212690800032', 0, 0, NULL, 1, 0, N'massif', N'abdessamed', null)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from [security].[users] where id='8a835b42-dafc-4247-a4a3-9683b300fc51'");
        }
    }
}
