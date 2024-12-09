using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class RosterProvider
    {
        private readonly DatabaseContext _context;
        public event Action? OnRosterUpdated;

        public RosterProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task AddRosterAsync(Roster roster)
        {
            _context.Rosters.Add(roster);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRosterAsync(Roster roster)
        {
            // Remove the roster from the database
            _context.Rosters.Remove(roster);
            await _context.SaveChangesAsync();

            // Safely invoke
            if (OnRosterUpdated != null)
            {
                foreach (var handler in OnRosterUpdated.GetInvocationList())
                {
                    if (handler is Func<Task> asyncHandler)
                    {
                        await asyncHandler();
                    }
                    else
                    {
                        ((Action)handler)?.Invoke();
                    }
                }
            }
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
