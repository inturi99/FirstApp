using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
  public  class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OwnerId { get; set; }
        public User Owner { get; set; }
        public List<User> Colabrators { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
