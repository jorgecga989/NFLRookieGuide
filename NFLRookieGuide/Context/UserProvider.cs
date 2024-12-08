using Microsoft.AspNetCore.Identity;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class UserProvider
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;

        public UserProvider(DatabaseContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public User? GetUserByUsername(string? username)
        {
            // Return the user with the specified username
            return _context.Users.FirstOrDefault(user => user.UserName == username);
        }

        public async Task<User?> GetUserByIdAsync(string? id)
        {
            // Return the user with the id
            return await _context.Users.FindAsync(id);
        }

    }
}
