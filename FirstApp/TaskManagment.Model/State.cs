using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Model
{
   public class State
    {

       public State()
       {
          
               CreateDateTime = UpdateDateTime = DateTime.Now;
           
       }
        public Guid StateId { get; set; }
        public Guid CountryId { get; set; }
        public string StateName { get; set; }
        public virtual Country Country { get; set; }

        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid UpdatedUserId { get; set; }
       
        public RowStatus RowStatus { get; set; }

        public ICollection<User> User { get; set; }
    }
}
