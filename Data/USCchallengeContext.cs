using Microsoft.EntityFrameworkCore;
using USCchallenge.Models;

namespace USCchallenge.Data
{
    public class USCchallengeContext : DbContext
    {
        public USCchallengeContext (DbContextOptions<USCchallengeContext> options)
            : base(options)
        {
        }

        public DbSet<Challenge> Challenge { get; set; }
    }
}
