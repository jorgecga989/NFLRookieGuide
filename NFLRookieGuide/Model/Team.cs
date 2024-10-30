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

        public string PrimaryColour()
        {
            string[] DisplayColours = Colours.Split(" , ");//takes the colours property and takes the first word, the colour I need
            return DisplayColours[0].ToLower();
            
        }

        //public string StadiumName()
        //{
        //    string[] NameStadium = Stadium.IndexOf(".");

        //}
    }
}
