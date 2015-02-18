using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne
{
   public  class UserImage
    {
       public int ImageId { get; set; }
       public byte[] Image { get; set; }
       public User Users { get; set; }
    }
}
