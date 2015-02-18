using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Mappings
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            HasKey(t => t.TaskId);
            Property(t => t.TaskId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Title).IsRequired().HasMaxLength(250);
            Property(t => t.Priority).IsRequired().HasMaxLength(10);
            Property(t => t.CompletionDate).IsOptional();
            Property(t => t.Status).IsRequired().HasMaxLength(50);
            Property(t => t.UserId).IsRequired();
            Property(t => t.Description).IsOptional().HasMaxLength(1000);
            Property(t => t.CreationDate).IsRequired();
            HasRequired(t => t.Project).WithMany(t => t.Tasks).HasForeignKey(t => t.ProjectId).WillCascadeOnDelete(false);

        }
    }
}
