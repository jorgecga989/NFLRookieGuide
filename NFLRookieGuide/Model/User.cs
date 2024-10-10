using Microsoft.AspNetCore.Identity;

namespace NFLRookieGuide.Model
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Roster> Rosters { get; set; }
    }
}
