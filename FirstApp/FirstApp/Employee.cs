using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
 public    class Employee
    {
     public int ID { get; set; }
     public string employeeId { get; set; }
     public string employeeName { get; set; }
     public decimal salary { get; set; }
     public int CountryID { get; set; }
     public int StateID { get; set; }

     public string address { get; set; }

     public virtual Country Country { get; set; }
     public virtual State State { get; set; }

    }
}
