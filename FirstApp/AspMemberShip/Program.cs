using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMemberShip
{
    public class MyUser : IdentityUser
    {
        public virtual MyUserInfo MyUserInfo { get; set; }
    }
    public class MyUserInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class MyDbContext : IdentityDbContext<MyUser>
    {
        public MyDbContext()
            : base("AspMemberShipContext")
        {
        }
        public System.Data.Entity.DbSet<MyUserInfo> MyUserInfo { get; set; }
 
    }

    


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
