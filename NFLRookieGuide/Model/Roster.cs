namespace NFLRookieGuide.Model
{
    public class Roster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date_created { get; set; }
        public List<PlayerAPI?> PlayerAPI { get; set; }
        public List<string?> SelectedPlayers { get; set; }
    }
}
