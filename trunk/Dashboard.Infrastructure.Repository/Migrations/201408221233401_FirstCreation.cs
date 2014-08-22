namespace Dashboard.Infrastructure.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false, maxLength: 200),
                        Name = c.String(nullable: false, maxLength: 200),
                        HomeAddress = c.String(maxLength: 400),
                        WorkAddress = c.String(maxLength: 400),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PhoneTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PhoneTypes", t => t.PhoneTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PhoneTypeId);
            
            CreateTable(
                "dbo.PhoneTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPhones", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserPhones", "PhoneTypeId", "dbo.PhoneTypes");
            DropIndex("dbo.UserPhones", new[] { "PhoneTypeId" });
            DropIndex("dbo.UserPhones", new[] { "UserId" });
            DropTable("dbo.PhoneTypes");
            DropTable("dbo.UserPhones");
            DropTable("dbo.Users");
        }
    }
}
