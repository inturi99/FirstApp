using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisrtProject
{
   class VetContext : DbContext 
    {
      public VetContext()
           : base(@"Data Source=192.168.0.11\TECHNOID;Initial Catalog=EFCF;User ID=sa;Password=Design_20")
        
      {

      }
      public DbSet<Patient> Patients { get; set; }
      public DbSet<Visit> Visits { get; set; }

     
    }
}
