using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class TeamProvider
    {
        private readonly DatabaseContext _context;

        public TeamProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Team>> GetAllTeamsAsync()
        {
            return await _context.Teams.OrderBy(team => team.Name).ToListAsync();
        }

        public Team? GetTeam(int id)
        {
            return _context.Teams.Find(id);
        }
    }
}
