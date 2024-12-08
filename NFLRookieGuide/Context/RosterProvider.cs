﻿using Microsoft.EntityFrameworkCore;
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

        public async Task AddRosterAsync(Roster roster)
        {
            _context.Rosters.Add(roster);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Roster>?> GetRostersAsync(User? user)
        {
            if (user == null) return null;

            return await _context.Rosters
                .Where(roster => roster.User.UserName == user.UserName)
                .OrderByDescending(roster => roster.Date_created)
                .ToListAsync();
        } //Gets roters created by the user  logged in
        public async Task<List<Roster>> GetAllRostersAsync()
        {
            return await _context.Rosters.OrderBy(roster => roster.Name).ToListAsync();
        }
        public async Task UpdateRosterAsync(Roster roster)
        {
            _context.Rosters.Update(roster);
            await _context.SaveChangesAsync();
        }
    }
}
