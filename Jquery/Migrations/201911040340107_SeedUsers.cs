namespace Jquery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7d16920c-289c-416d-95de-47353db46742', N'Admin@aol.com', 0, N'AO9uYgDpzEq6wNkWhQpYNcJYKdGsqyPuw7PMQlPSp31X1PzPK5phRnGrNXa7A+9LZw==', N'fffea322-ff50-4fa8-916c-592617019c0c', NULL, 0, 0, NULL, 1, 0, N'Admin@aol.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cafd08a1-952d-44a4-8987-d7fd763612a9', N'Guest@aol.com', 0, N'AJizzaz1HvTANdGDsYFaySR3Nw+oMtau6TR2NJX69fIPCkDTXhb3F0fu2OguPAddgQ==', N'fae789e0-4390-44c7-affa-03e295c2faca', NULL, 0, 0, NULL, 1, 0, N'Guest@aol.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a43cfef4-115a-4f5a-a817-afc8d95a7665', N'CanManageEmployees')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7d16920c-289c-416d-95de-47353db46742', N'a43cfef4-115a-4f5a-a817-afc8d95a7665')
");
        }
        
        public override void Down()
        {
        }
    }
}
