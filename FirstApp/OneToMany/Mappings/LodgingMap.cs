using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany.Mappings
{
   public class LodgingMap :EntityTypeConfiguration<Lodging>
   {
       public LodgingMap()
       {
           HasKey(l=>l.LodgingId);
           Property(l=>l.LodgingId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(l => l.Name).IsRequired().HasMaxLength(100);
           Property(l => l.Owner).IsRequired().HasMaxLength(100);
           Property(l => l.IsResort).IsRequired();
           Property(l => l.MilesFromNearestAirport).IsRequired().HasPrecision(3,2);
           //Property(l => l.DestinationId).IsRequired();
           HasRequired(l => l.Destination).WithMany(l => l.Lodgings).HasForeignKey(l => l.DestinationId);
       }
    }
}
