using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
  public   class Mappings
    {
        public class DestinationConfiguration :EntityTypeConfiguration<SecondProject.SecondProjectModel.Destination>
        {
            public DestinationConfiguration()
            {
                Property(d => d.DestinationId).IsRequired();
                Property(d => d.DestionationName).IsRequired();
                Property(d => d.Description).HasMaxLength(500);
               
            }
        }
        public class LodgingConfiguration :EntityTypeConfiguration<SecondProject.SecondProjectModel.Lodging>
        {
            public LodgingConfiguration()
            {
                Property(l => l.LodgingName).IsRequired().HasMaxLength(200);
            }
        }
    }
}
