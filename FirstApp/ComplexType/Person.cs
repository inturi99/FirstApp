using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexType
{
   public class Person
    {
       public Person()
       {
       Addresses=new Address();
       }
       public int PersonId { get; set; }
       public int SocialSecurityNumber { get; set; }
       public string FirstName { get; set; }
       public String LastName { get; set; }
       public Address Addresses { get; set; }
    }
}
