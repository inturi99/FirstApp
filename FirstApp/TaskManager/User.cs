using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public sealed class User :IdentityUser 
    {
        public List<Project> ProjectsOwn { get; set; }
        public List<Project> CollaberatedProjects { get; set; }
        public  List<Task> Tasks { get; set; } 

    }
}
