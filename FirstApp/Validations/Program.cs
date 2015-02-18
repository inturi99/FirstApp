using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using OneToMany.Migrations;

namespace OneToMany
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BloggingContext, Configuration>());
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                string name = Console.ReadLine();

                var blog = new Blog {Name = name};
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database 
                IOrderedQueryable<Blog> query = from b in db.Blogs
                    orderby b.Name
                    select b;

                Console.WriteLine("All blogs in the database:");
                foreach (Blog item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        public class Blog : IValidatableObject
        {
            public int BlogId { get; set; }
            public string Name { get; set; }
            //public string Url { get; set; }
            public int Rating { get; set; }
            public virtual List<Post> Posts { get; set; }

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                return null;
            }
        }

        public class BloggingContext : DbContext
        {
            public BloggingContext()
                : base("BlogContext")
            {
            }

            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<ApplicationUser> ApplicationUsers { get; set; }


            //protected override void OnModelCreating(DbModelBuilder modelBuilder)
            //{
            //    base.OnModelCreating(modelBuilder);
            //    modelBuilder.Entity<ApplicationUser>().HasKey<int>(l => l.UserId);
            //}

            protected override DbEntityValidationResult ValidateEntity(
                DbEntityEntry entityEntry,
                IDictionary<object, object> items)
            {
                var result = new DbEntityValidationResult(entityEntry, new List<DbValidationError>());
                if (entityEntry.Entity is Blog && entityEntry.State == EntityState.Added)
                {
                    var blog = entityEntry.Entity as Blog;

                    if (Blogs.Where(b => b.Name == blog.Name).Count() > 0)
                    {
                        result.ValidationErrors.Add(
                            new DbValidationError("Name",
                                "BlogName title must be unique."));
                    }
                }

                if (result.ValidationErrors.Count > 0)
                {
                    return result;
                }
                return base.ValidateEntity(entityEntry, items);
            }
        }

        public class Post : IValidatableObject
        {
            public int PostId { get; set; }

            [MaxLength(200)]
            public string Title { get; set; }

            public string Content { get; set; }
            public string Abstract { get; set; }

            public int BlogId { get; set; }
            public virtual Blog Blog { get; set; }

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                return null;
            }
        }
    }
}