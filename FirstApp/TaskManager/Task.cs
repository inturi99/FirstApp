using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
   public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }

        public string Description { get; set; }
        public string UserId { get; set; }
        public User AssignedTo { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
