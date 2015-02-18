using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Mappings
{
  public  class TaskMap:EntityTypeConfiguration<Task>
  {
      public TaskMap()
      {
          HasKey(t => t.TaskId);
          Property(t => t.TaskId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          Property(t => t.TaskName).IsRequired().HasMaxLength(100);
      }
    }
}
