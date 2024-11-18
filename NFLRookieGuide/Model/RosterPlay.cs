namespace NFLRookieGuide.Model
{
    public class RosterPlay
    {
        public int Id { get; set; }
        public int? Slot1 { get; set; }
        public int? Slot2 { get; set; }
        public int? Slot3 { get; set; }
        public int? Slot4 { get; set; }
        public int? Slot5 { get; set; }
        public int? Slot6 { get; set; }
        public int? Slot7 { get; set; }
        public int? Slot8 { get; set; }
        public int? Slot9 { get; set; }
        public int? Slot10 { get; set; }
        public Roster Roster { get; set; } //identifies which roster this play belongs to
        public Play Play { get; set; } //identifies the details of the actual play
    }
}
