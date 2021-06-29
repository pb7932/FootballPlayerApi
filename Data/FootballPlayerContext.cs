using FootballPlayerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FootBallPlayerApi.Data
{
    public class FootballPlayerContext : DbContext
    {
        public FootballPlayerContext(DbContextOptions<FootballPlayerContext> options) : base(options)
        {

        }

        public DbSet<FootballPlayer> FootballPlayers { get; set; }
    }
}