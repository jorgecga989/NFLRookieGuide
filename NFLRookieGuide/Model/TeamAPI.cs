namespace NFLRookieGuide.Model
{
    public class TeamApi
    {
        public string id { get; set; }
        public string name { get; set; }
        public PlayerAPI[] players { get; set; }
    }
    public class PlayerAPI
    {
        public string id { get; set; }
        public string name { get; set; }
        public string jersey { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string birth_date { get; set; }
        public float weight { get; set; }
        public int height { get; set; }
        public string position { get; set; }
        public string birth_place { get; set; }
        public string high_school { get; set; }
        public string college { get; set; }
        public int rookie_year { get; set; }
    }


}
