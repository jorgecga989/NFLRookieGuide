namespace NFLRookieGuide.Model
{
    public class RosterPlay
    {
        public int Id { get; set; }
        //slots can be empty
        public string? Slot1 { get; set; }
        public string? Slot2 { get; set; }
        public string? Slot3 { get; set; }
        public string? Slot4 { get; set; }
        public string? Slot5 { get; set; }
        public string? Slot6 { get; set; }
        public string? Slot7 { get; set; }
        public string? Slot8 { get; set; }
        public string? Slot9 { get; set; }
        //10 slots available for users
        public string? Slot10 { get; set; }
    }
}
