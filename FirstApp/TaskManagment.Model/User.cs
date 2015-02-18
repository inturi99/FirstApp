using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.Model
{
   
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserId { get; set; }
      
        public string UserName { get; set; }

        public Gender Gender { get; set; }
        public string Address { get; set; }

        public Guid StateId { get; set; }
        public virtual State State { get; set; }

        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }

        public Guid CreatedUserId { get; set; }
        public Guid UpdatedUserId { get; set; }
      
        public RowStatus RowStatus { get; set; }
    }
}
