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

        //public async Task AddRosterPlayAsync(/*Cheese cheese, User user, int stars*/)
        //{
        //    // if the user has already rated this cheese, update the rating else add a new rating
        //    var rosterplay = _context.RosterPlay.FirstOrDefault(r => r.Cheese == cheese && r.User == user);
        //    if (rating != null)
        //    {
        //        rating.Stars = stars;
        //    }
        //    else
        //    {
        //        rating = new Rating { Cheese = cheese, User = user, Stars = stars };
        //        _context.Ratings.Add(rating);
        //    }
        //    await _context.SaveChangesAsync();
        //}
    }
}
