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
        } //gets context(teams) 

        public async Task<List<Team>> GetAllTeamsAsync()
        {
            return await _context.Teams.OrderBy(team => team.Name).ToListAsync();
        } //makes a list of teams in alphabetical order

        public Team? GetTeam(int id)
        {
            return _context.Teams.Find(id);
        }
    }
}
