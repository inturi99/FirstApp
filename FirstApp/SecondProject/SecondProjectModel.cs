using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
  public  class SecondProjectModel
    {
        public class Destination
        {
            
            public int DestinationId { get; set; }
            public string DestionationName { get; set; }
            public string Country { get; set; }
            public string Description { get; set; }
       

        }

        public class Lodging
        {
           
            public int Id { get; set; }
            public string LodgingName { get; set; }
            public string Owner { get; set; }
           
            public int DestinationId { get; set; }
           
            public virtual Destination Destination { get; set; }
        }

    }
}
