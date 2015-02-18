using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Model;

namespace TaskManagment.Data.Mappings
{
    public class UserMap :EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(it => it.UserId);
            Property(it => it.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(it => it.UserName).IsRequired();
           // Property(it => it.Address).IsOptional();
            
           // Property(it=>it.Gender).
           // HasRequired(it => it.State).WithMany(it => it.User).HasForeignKey(it => it.StateId);
        }
    }
}
