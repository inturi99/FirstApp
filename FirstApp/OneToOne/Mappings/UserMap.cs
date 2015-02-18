using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Mappings
{
  public class UserMap:EntityTypeConfiguration<User>
  {
      public UserMap()
      {
          HasKey(u => u.UserId);
          Property(u => u.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          Property(u => u.UserName).IsRequired().HasMaxLength(25);
      }
    }
}
