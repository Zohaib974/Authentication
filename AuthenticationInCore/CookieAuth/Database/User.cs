using Microsoft.AspNetCore.Identity;

namespace CookieAuth.Database
{
    public class User  : IdentityUser
    {
        public string? Fullname { get; set; }   
    }
}
