using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class DatabaseSeeder
    {

        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;
     
        public DatabaseSeeder(DatabaseContext context, UserManager<User> userManager)
        {
         _context = context;
         _userManager = userManager;
        }

        public async Task Seed()
        {
            await _context.Database.MigrateAsync();
            
            
        }
    }
}
