namespace NFLRookieGuide.Model
{
    public class Play
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Diagram { get; set; }
        public Position? Position1 { get; set; }
        public Position? Position2 { get; set; }
        public Position? Position3 { get; set; }
        public Position? Position4 { get; set; }
        public Position? Position5 { get; set; }
        public Position? Position6 { get; set; }
        public Position? Position7 { get; set; }
        public Position? Position8 { get; set; }
        public Position? Position9 { get; set; }
        public Position? Position10 { get; set; }
        public List<RosterPlay> RosterPlays { get; set;}//list of the rosters using this play

    }
}
