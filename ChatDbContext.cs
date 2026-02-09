using Microsoft.EntityFrameworkCore;

namespace _20260129
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<ChatConversation> Conversations { get; set; }
    }
}
