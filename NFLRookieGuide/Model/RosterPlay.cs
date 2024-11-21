namespace NFLRookieGuide.Model
{
    public class RosterPlay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string?> SelectedSlots { get; set; }
    }
}
