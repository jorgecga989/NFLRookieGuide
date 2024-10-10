namespace NFLRookieGuide.Model
{
    public class RosterPlayer
    {
        public int Id { get; set; }
        public Roster Roster { get; set; }
        public Player Player { get; set; }
    }
}
