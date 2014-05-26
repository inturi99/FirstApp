using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class TestEntities : DbContext
    {
        public TestEntities()
            : base(@"Data Source=TECHNO-KRISHNA\SQLEXPRESS;Initial Catalog=Test;User ID=sa;Password=Design_20")
        {

        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }
        public DbSet<Employee> Employies { get; set; }
    }
}
