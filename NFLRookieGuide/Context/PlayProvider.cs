using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class PlayProvider
    {
        private readonly DatabaseContext _context;

        public PlayProvider(DatabaseContext context)
        {
            _context = context;
        } //gets context(play) 

        public async Task<List<Play>> GetAllPlaysAsync()
        {
            return await _context.Plays.OrderBy(play => play.Name).ToListAsync();
        } //makes a list of plays in alphabetical order

        public Play? GetPlay(int id)
        {
            return _context.Plays.Find(id);
        }
    }
}
