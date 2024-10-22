using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;


namespace NFLRookieGuide.Context
{
    public class PlayerProvider
    {
        private readonly DatabaseContext _context;

        public PlayerProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Player>> GetAllPlayersAsync()
        {
            return await _context.Player.OrderBy(player => player.Name).ToListAsync();
        }

        public Player? GetPlayer(int id)
        {
            return _context.Player.Find(id);
        }
    }
}
