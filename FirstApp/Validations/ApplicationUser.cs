using Microsoft.AspNet.Identity.EntityFramework;

namespace OneToMany
{
    public class ApplicationUser : IdentityUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
    }
}