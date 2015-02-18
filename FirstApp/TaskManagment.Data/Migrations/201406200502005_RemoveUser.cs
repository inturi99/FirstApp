namespace TaskManagment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "StateId", "dbo.States");
            DropIndex("dbo.Users", new[] { "StateId" });
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.UserId);
            
            CreateIndex("dbo.Users", "StateId");
            AddForeignKey("dbo.Users", "StateId", "dbo.States", "StateId", cascadeDelete: true);
        }
    }
}
