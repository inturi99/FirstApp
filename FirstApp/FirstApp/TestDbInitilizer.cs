using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class TestDbInitilizer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TestEntities>
    {
        protected override void Seed(TestEntities context)
        {

            context.Countries.Add(new Country
            {
                Name = "INDIA"
            });
            context.SaveChanges();

            context.States.Add(new State 
            { 
                CountryID=1,
                Name="AndhraPradesh"

            });
            context.SaveChanges();

            context.Employies.Add(new Employee { 
            employeeId="VTI-001",
            employeeName="Srinivas.G",
            CountryID=1,
            StateID=1,
            salary=38000,
            address="Technoidentity"
            });
            context.SaveChanges();
        }
    }
}
