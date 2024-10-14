namespace NFLRookieGuide.Model
{
    public class Play
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number_players { get; set; }
        public List<RosterPlay> RosterPlays { get; set;}//list of the rosters using this play

    }
}
