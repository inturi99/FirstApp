namespace SecondProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        DestionationName = c.String(nullable: false),
                        Country = c.String(),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.Lodgings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LodgingName = c.String(nullable: false, maxLength: 200),
                        Owner = c.String(),
                        DestinationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Destinations", t => t.DestinationId, cascadeDelete: true)
                .Index(t => t.DestinationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lodgings", "DestinationId", "dbo.Destinations");
            DropIndex("dbo.Lodgings", new[] { "DestinationId" });
            DropTable("dbo.Lodgings");
            DropTable("dbo.Destinations");
        }
    }
}
