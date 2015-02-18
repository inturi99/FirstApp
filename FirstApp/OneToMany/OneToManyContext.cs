using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToMany.Mappings;

namespace OneToMany
{
    public class ComplexTypeContext : DbContext
    {
        public ComplexTypeContext()
            : base("OneToManyBDContext")
        {

        }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new DestinationMap());
            modelBuilder.Configurations.Add((new LodgingMap()));
            
        }
    }
}
