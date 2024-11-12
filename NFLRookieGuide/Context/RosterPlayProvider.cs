using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class RosterPlayProvider
    {
        private readonly DatabaseContext _context;

        public RosterPlayProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task AddRosterPlayAsync(RosterPlay rosterPlay)
        {
            _context.RosterPlays.Add(rosterPlay);
            await _context.SaveChangesAsync();
        }

        public async Task<RosterPlay> GetRosterPlayByIdAsync(int id)
        {
            return await _context.RosterPlays
                .Include(rp => rp.Play)  // Include the Play property for eager loading
                .FirstOrDefaultAsync(rp => rp.Id == id);
        }

        public async Task<IEnumerable<RosterPlay>> GetAllRosterPlaysAsync()
        {
            return await _context.RosterPlays
                .Include(rp => rp.Play)  // Include the Play property for eager loading
                .ToListAsync();
        }

        public async Task UpdateRosterPlayAsync(RosterPlay rosterPlay)
        {
            _context.RosterPlays.Update(rosterPlay);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRosterPlayAsync(int id)
        {
            var rosterPlay = await _context.RosterPlays.FindAsync(id);
            if (rosterPlay != null)
            {
                _context.RosterPlays.Remove(rosterPlay);
                await _context.SaveChangesAsync();
            }
        }
    }
}
