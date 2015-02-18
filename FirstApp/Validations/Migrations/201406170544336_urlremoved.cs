using System.Data.Entity.Migrations;

namespace OneToMany.Migrations
{
    public partial class urlremoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Blogs", "Url");
        }

        public override void Down()
        {
            AddColumn("dbo.Blogs", "Url", c => c.String());
        }
    }
}