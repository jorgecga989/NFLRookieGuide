namespace NFLRookieGuide.Model
{
    public class RosterPlay
    {
        public int Id { get; set; }
        public Roster Roster { get; set; }
        public Play Play { get; set; }
    }
}
