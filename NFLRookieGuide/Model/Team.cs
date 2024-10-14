namespace NFLRookieGuide.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Colours { get; set; }
        public string Mascot { get; set; }
        public string Stadium { get; set; }
        public DateTime Date_founded { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; set; } //This teams list of players
    }
}
