using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using TaskManager.Mappings;

namespace TaskManager
{
    public class TaskManagerContext : IdentityDbContext<IdentityUser>
    {
        public TaskManagerContext()
            : base("TaskManager")
        {
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new TaskMap());
            modelBuilder.Configurations.Add(new UserMap());
           
            modelBuilder.Entity<Project>().
                HasMany(c => c.Colabrators).
                WithMany(p => p.ProjectsOwn);
           
            modelBuilder.Entity<Project>().
                HasMany(c => c.Colabrators).
                WithMany(p => p.CollaberatedProjects);
            
        }
       

    }
}
