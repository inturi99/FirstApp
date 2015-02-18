using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Employee
    {
        public int ID { get; set; }
        public string employeeId { get; set; }
        [Required]
        public string employeeName { get; set; }
      
        public decimal salary { get; set; }

        public int StateId { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }

        public string address { get; set; }



    }
}
