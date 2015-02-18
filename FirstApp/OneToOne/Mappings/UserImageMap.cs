using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Mappings
{
  public  class UserImageMap:EntityTypeConfiguration<UserImage>
  {
      public UserImageMap()
      {
          HasKey(ui => ui.ImageId);
          Property(ui => ui.ImageId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          Property(ui => ui.Image).IsRequired();
          HasRequired(ui => ui.Users).WithRequiredDependent(ui => ui.UserImages);
      }
    }
}
