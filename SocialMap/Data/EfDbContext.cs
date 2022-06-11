using Microsoft.EntityFrameworkCore;

namespace SocialMap.Data
{
    public class EfDbContext:DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options):base(options)
        {


        }

        public DbSet<Friendship> Friendships { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<GroupMember> GroupMembers { get; set; }

        public DbSet<GroupMessage> GroupMessages { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserMessage> UserMessages { get; set; }
    
    }
}
