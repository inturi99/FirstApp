using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexType
{
   public class ComplexTypeContext :DbContext
    {
       public ComplexTypeContext() :base("ComplexTypeBDContext")
       {
           
       }
       public DbSet<Person> Persons { get; set; }
       public DbSet<Address> Addresses { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           base.OnModelCreating(modelBuilder);
           modelBuilder.ComplexType<Address>().Property(a=>a.StreetAddress).HasMaxLength(1000);

       }
    }
}
