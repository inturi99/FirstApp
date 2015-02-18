using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManyToMany.Mappings;

namespace ManyToMany
{
      public class ManyToManyContext : DbContext
        {
            public ManyToManyContext()
                : base("ManyToManyContext")
            {

            }
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Tag> Tags { get; set; }
            

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Configurations.Add(new BlogMap());
                modelBuilder.Configurations.Add((new PostMap()));
                modelBuilder.Configurations.Add(new TagMap());
                
                modelBuilder.Entity<Post>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .Map(mc =>
                {
                    mc.ToTable("PostJoinTag");
                    mc.MapLeftKey("PostId");
                    mc.MapRightKey("TagId");
                });

            }
        }
    }

