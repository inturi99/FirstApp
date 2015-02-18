using System.Data.Entity.Migrations;

namespace OneToMany.Migrations
{
    public partial class IntialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                {
                    BlogId = c.Int(false, true),
                    Name = c.String(),
                    Url = c.String(),
                    Rating = c.Int(false),
                })
                .PrimaryKey(t => t.BlogId);

            CreateTable(
                "dbo.Posts",
                c => new
                {
                    PostId = c.Int(false, true),
                    Title = c.String(maxLength: 200),
                    Content = c.String(),
                    Abstract = c.String(),
                    BlogId = c.Int(false),
                })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Blogs", t => t.BlogId, true)
                .Index(t => t.BlogId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] {"BlogId"});
            DropTable("dbo.Posts");
            DropTable("dbo.Blogs");
        }
    }
}