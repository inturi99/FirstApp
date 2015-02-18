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
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap() {
            HasKey(it => it.StateId);
            Property(it => it.StateId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(it => it.StateName).IsRequired();
            HasRequired(it => it.Country).WithMany(it => it.State).HasForeignKey(it=>it.CountryId);
           
            
            //Property(it => it.CountryID).IsRequired();
            
    }
}
}
