namespace NFLRookieGuide.Model
{
    public class RosterPlay
    {
        public int Id { get; set; }
        //slots can be empty
     public List<string?> SelectedSlots { get; set; }
    }
}
