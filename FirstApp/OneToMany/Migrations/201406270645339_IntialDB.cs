namespace OneToMany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Country = c.String(),
                        Description = c.String(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.Lodgings",
                c => new
                    {
                        LodgingId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Owner = c.String(nullable: false, maxLength: 100),
                        IsResort = c.Boolean(nullable: false),
                        MilesFromNearestAirport = c.Decimal(nullable: false, precision: 3, scale: 2),
                        DestinationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LodgingId)
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
