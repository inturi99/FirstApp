using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    public class BreakAwayContext : DbContext
    {
        public BreakAwayContext()
            : base(@"Data Source=192.168.0.11\TECHNOID;Initial Catalog=EFCF;User ID=sa;Password=Design_20")
        {

        }

        public DbSet<SecondProject.SecondProjectModel.Destination> Destinations { get; set; }
        public DbSet<SecondProject.SecondProjectModel.Lodging> Lodging { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SecondProject.Mappings.DestinationConfiguration());
            modelBuilder.Configurations.Add(new SecondProject.Mappings.LodgingConfiguration());
        }

    }
}