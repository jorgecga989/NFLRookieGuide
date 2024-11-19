namespace NFLRookieGuide.Model
{
    public class Roster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_created { get; set; }
        public List<RosterPlayer> RosterPlayers { get; set; } //lists players used for this roster and their characteristics
    }
}
