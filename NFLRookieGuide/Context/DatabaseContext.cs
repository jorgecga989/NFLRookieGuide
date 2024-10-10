using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DbSet<Roster> Rosters { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Teams{ get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            var dbPath = Path.Join(path, "playerbase.db");
            optionbuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
