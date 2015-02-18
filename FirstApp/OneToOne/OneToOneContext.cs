using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToOne.Mappings;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OneToOne
{
  public  class OneToOneContext:IdentityDbContext<IdentityUser>
    {
      public OneToOneContext()
          : base("onetonecontext")
      {
          
      }
      public DbSet<Project> Projects { get; set; }
      public DbSet<Task> Tasks { get; set; }
      public DbSet<User> Users { get; set; }
      public DbSet<UserImage> UserImages { get; set; } 
      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
          base.OnModelCreating(modelBuilder);
          modelBuilder.Configurations.Add(new ProjectMap());
          modelBuilder.Configurations.Add(new TaskMap());
          modelBuilder.Configurations.Add(new UserMap());
          modelBuilder.Configurations.Add(new UserImageMap());
      }
    }
}
