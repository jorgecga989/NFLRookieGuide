using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class PositionProvider
    {
        private readonly DatabaseContext _context;

        public PositionProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Position>> GetAllPositionsAsync()
        {
            return await _context.Positions.OrderBy(position => position.Name).ToListAsync();
        }

        public Position? GetPosition(int id)
        {
            return _context.Positions.Find(id);
        }
    }
}
