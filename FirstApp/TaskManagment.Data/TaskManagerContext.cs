using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Data.Mappings;
using TaskManagment.Model;

namespace TaskManagment.Data
{
  public  class TaskManagerContext:DbContext
    {
      public TaskManagerContext()
          : base(@"Data Source=192.168.0.11\TECHNOID;Initial Catalog=EFCF;User ID=sa;Password=Design_20")
      {

      }
      public DbSet<Country> Countries { get; set; }

      public DbSet<State> States { get; set; }
      public DbSet<User> Users { get; set;}
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Entity<User>().Ignore(t => t.Address);
            modelBuilder.Ignore<User>();
           // modelBuilder.Entity<Country>().Property(i => i.CountryId).IsRequired();
          
          

        }
    }
}
