namespace NFLRookieGuide.Model
{
    public class Roster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_created { get; set; }
        public List<RosterPlay>RosterPlays { get; set; } //lists details of the plays the user will be using for this roster
        public List<RosterPlayer> RosterPlayers { get; set; } //lists players used for this roster and their characteristics
    }
}
