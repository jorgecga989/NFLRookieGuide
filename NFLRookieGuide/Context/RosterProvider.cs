using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class RosterProvider
    {
        private readonly DatabaseContext _context;

        public RosterProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task AddRoster(Roster roster)
        {
            _context.Rosters.Add(roster);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Roster>> GetAllRostersAsync()
        {
            return await _context.Rosters.OrderBy(roster => roster.Name).ToListAsync();
        }

        public Roster? GetRoster(int id)
        {
            return _context.Rosters.Find(id);
        }
    }
}
