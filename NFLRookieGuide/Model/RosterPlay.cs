namespace NFLRookieGuide.Model
{
    public class RosterPlay
    {
        public int Id { get; set; }
        public Roster Roster { get; set; } //identifies which roster this play belongs to
        public Play Play { get; set; } //identifies the details of the actual play
    }
}
