namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7a3ba4ce-d62e-4671-b514-57db329f8db2', N'user@Vidly.com', 0, N'AImW/I7uylAm59j60xHwJNUFiagATWDDnjY7uoBSAksQXTNmSjVVT5GpNZgyDNQSzw==', N'bf322f97-935c-4cc6-9a4a-c02fd16d4fc7', NULL, 0, 0, NULL, 1, 0, N'user@Vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e7ee4d11-db91-47dc-af67-eae8c34162dd', N'baotluong@gmail.com', 0, N'ADjC1YrriTKTUE8OGPeu7uAelSr4C5emXJxHJDN8+42PNESOwvMD+5+2Pdg9Qk+pPw==', N'5a9419f1-71fb-4e30-96db-455c9e72549f', NULL, 0, 0, NULL, 1, 0, N'baotluong@gmail.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fa3d3f9a-331e-482b-ad4d-fe01c9b799a2', N'CanManageMovies')
            
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e7ee4d11-db91-47dc-af67-eae8c34162dd', N'fa3d3f9a-331e-482b-ad4d-fe01c9b799a2')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
