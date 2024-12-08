namespace NFLRookieGuide.Model
{
    public class Roster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date_created { get; set; }
        public User User { get; set; }
        public List<string?> SelectedPlayers { get; set; }
        public List<RosterPlay> RosterPlays { get; set; }
    }
}
