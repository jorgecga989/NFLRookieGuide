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
        public async Task<List<RosterPlay>> GetAllRosterPlaysAsync()
        {
            return await _context.RosterPlays.OrderBy(rosterPlay => rosterPlay.Name).ToListAsync();
        }

        public async Task<RosterPlay?> NewestPlayAsync()
        {
            return await _context.RosterPlays.OrderByDescending(RosterPlay => RosterPlay.Id).FirstOrDefaultAsync();
            //Gets the play that the user recently created
        }

        public async Task<RosterPlay?> SelectedPlayAsync(Roster roster)
        {
            return await _context.RosterPlays
                .FirstOrDefaultAsync(rp => rp.Id == roster.Id);
        }

        public async Task AddRosterPlayAsync(RosterPlay rosterPlay)
        {
            _context.RosterPlays.Add(rosterPlay);
            await _context.SaveChangesAsync();
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
