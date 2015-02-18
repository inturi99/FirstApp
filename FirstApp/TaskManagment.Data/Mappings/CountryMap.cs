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
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            HasKey(c => c.CountryId);
            Property(c => c.CountryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.CountryName).IsRequired().HasMaxLength(1000);
        }
    }
}
