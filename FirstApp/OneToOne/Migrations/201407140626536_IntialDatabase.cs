namespace OneToOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(nullable: false, maxLength: 25),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserImages",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        Image = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.ImageId)
                .ForeignKey("dbo.Users", t => t.ImageId)
                .Index(t => t.ImageId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        TaskName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.TaskId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserImages", "ImageId", "dbo.Users");
            DropIndex("dbo.UserImages", new[] { "ImageId" });
            DropIndex("dbo.Projects", new[] { "UserId" });
            DropTable("dbo.Tasks");
            DropTable("dbo.UserImages");
            DropTable("dbo.Users");
            DropTable("dbo.Projects");
        }
    }
}
