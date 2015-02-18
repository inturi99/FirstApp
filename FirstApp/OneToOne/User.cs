using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
{
  public  class User
    {
      public int UserId { get; set; }
      public string UserName { get; set; }
     
      public UserImage UserImages { get; set; }
      public List<Project> Projects { get; set; } 
    }
}
