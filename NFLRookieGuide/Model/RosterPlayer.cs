namespace NFLRookieGuide.Model
{
    public class RosterPlayer
    {
        public int Id { get; set; }
        public Roster Roster { get; set; } //identifies which roster does the player belong to
        public Player Player { get; set; } //actual player fields
    }
}
