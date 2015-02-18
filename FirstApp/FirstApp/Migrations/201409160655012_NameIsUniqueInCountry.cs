namespace FirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameIsUniqueInCountry : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Countries", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Countries", new[] { "Name" });
        }
    }
}
