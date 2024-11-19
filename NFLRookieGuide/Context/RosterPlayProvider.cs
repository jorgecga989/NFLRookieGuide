﻿using Microsoft.EntityFrameworkCore;
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
