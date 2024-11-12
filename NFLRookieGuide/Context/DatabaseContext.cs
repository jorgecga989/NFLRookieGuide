using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        private IWebHostEnvironment _environment;
        public DbSet<Roster> Rosters { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Teams{ get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Play> Plays { get; set; }
        public DbSet<RosterPlay> RosterPlays { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options, IWebHostEnvironment environment) : base(options)
        {
            _environment = environment;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            var folder = Path.Combine(_environment.WebRootPath, "database");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            optionbuilder.UseSqlite($"Data Source={folder}/playerbase.db");
        }
    }
}
