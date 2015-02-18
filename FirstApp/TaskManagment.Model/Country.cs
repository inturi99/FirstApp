using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Model
{
  public  class Country{
    public Country()
        {
            CreateDateTime = UpdateDateTime = DateTime.Now;
        }

        public Guid CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
       
        public RowStatus RowStatus { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid UpdatedUserId { get; set; }

        public ICollection<State> State { get; set; }
  }
}
