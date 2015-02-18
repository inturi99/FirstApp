using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany.Mappings
{
   public class DestinationMap :EntityTypeConfiguration<Destination>
   {
       public DestinationMap()
       {
           HasKey(d => d.DestinationId);
           Property(d => d.DestinationId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(d => d.Name).IsRequired().HasMaxLength(100);
           Property(d => d.Country).IsRequired().HasMaxLength(100);
           Property(d => d.Description).IsOptional().HasMaxLength(1000);
       }
    }
}
