using Microsoft.AspNetCore.Identity;

namespace Demo1.Areas.Data
{
    public class AppUser : IdentityUser {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
    }
}
