using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Mappings
{
  public  class ProjectMap:EntityTypeConfiguration<Project>
  {
      public ProjectMap()
      {
          HasKey(p => p.ProjectId);
          Property(p => p.ProjectId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          Property(p => p.ProjectName).IsRequired().HasMaxLength(25);
          HasRequired(p => p.Users).WithMany(p => p.Projects).HasForeignKey(p => p.UserId);
      }
  }
}
