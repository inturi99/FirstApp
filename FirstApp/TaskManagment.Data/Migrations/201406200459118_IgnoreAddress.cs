namespace TaskManagment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IgnoreAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Guid(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 1000),
                        CreateDateTime = c.DateTime(nullable: false),
                        UpdateDateTime = c.DateTime(nullable: false),
                        RowStatus = c.Int(nullable: false),
                        CreatedUserId = c.Guid(nullable: false),
                        UpdatedUserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Guid(nullable: false, identity: true),
                        CountryId = c.Guid(nullable: false),
                        StateName = c.String(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreatedUserId = c.Guid(nullable: false),
                        UpdatedUserId = c.Guid(nullable: false),
                        RowStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StateId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Gender = c.Int(nullable: false),
                        StateId = c.Guid(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreatedUserId = c.Guid(nullable: false),
                        UpdatedUserId = c.Guid(nullable: false),
                        RowStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "StateId", "dbo.States");
            DropForeignKey("dbo.States", "CountryId", "dbo.Countries");
            DropIndex("dbo.Users", new[] { "StateId" });
            DropIndex("dbo.States", new[] { "CountryId" });
            DropTable("dbo.Users");
            DropTable("dbo.States");
            DropTable("dbo.Countries");
        }
    }
}
