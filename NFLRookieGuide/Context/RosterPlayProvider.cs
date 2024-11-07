using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class RosterPlayProvider
    {
        private List<Roster> _rosters;

        private readonly DatabaseContext _context;

        public RosterPlayProvider(DatabaseContext context)
        {
            _context = context;
        }

        public void AddPosition(Play position1, Play position2, Play position3, Play position4, Play position5, Play position6, Play position7, Play position8, Play position9, Play position10) {
            //var roster = _rosters.FirstOrDefault(roster => roster.Position.Id)
        }

        //public async Task AddRosterPlayAsync(/*Cheese cheese, User user, int stars*/)
        //{
        //  //if the user has already rated this cheese, update the rating else add a new rating
        //  var rosterplay = _context.RosterPlay.FirstOrDefault(r => r.Cheese == cheese && r.User == user);
        //  if (rating != null)
        //  {
        //      rating.Stars = stars;
        //  }
        //  else
        //  {
        //      rating = new Rating { Cheese = cheese, User = user, Stars = stars };
        //      _context.Ratings.Add(rating);
        //  }
        //  await _context.SaveChangesAsync();
        //  }
    }
}
