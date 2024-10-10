namespace NFLRookieGuide.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stats { get; set; }
        public string Description { get; set; }
        public string Photo {  get; set; }
        public int Age { get; set; }
        public List<RosterPlayer>RosterPlayers { get; set; }


    }
}
