using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SocialMap.Data
{
    public class JwtContext:IdentityDbContext<ApiUser>
    {

        public JwtContext(DbContextOptions<JwtContext> options) : base(options)
        {


        }

    }

    public class ApiUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string TC { get; set; }
    }


}
