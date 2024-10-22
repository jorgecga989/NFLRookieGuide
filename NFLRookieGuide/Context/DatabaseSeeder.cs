using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class DatabaseSeeder
    {

        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;
     
        public DatabaseSeeder(DatabaseContext context, UserManager<User> userManager)
        {
         _context = context;
         _userManager = userManager;
        }

        public async Task Seed()
        {
            await _context.Database.MigrateAsync();
            var teams = GetTeams();
            var positions = GetPosition();

            if (!_context.Teams.Any())
            {
                _context.Teams.AddRange(teams);
                await _context!.SaveChangesAsync();
            }

            if (!_context.Positions.Any())
            {
                _context.Positions.AddRange(positions);
                await _context!.SaveChangesAsync();
            }

            if(!_context.Player.Any())
            {
                var players = GetPlayers(teams, positions);
                _context.Player.AddRange(players);
                await _context!.SaveChangesAsync();
            }


        }
        private List<Player> GetPlayers(List<Team> teams, List<Position> position)
        {
            var p1 = new Player { Name = "Patrick Mahomes", Stats = 5000, Description = "Quarterback known for his arm strength and playmaking ability.", Photo = "patrick_mahomes.png", Age = 28, Team = teams[15], Position = position[0] };
            var p2 = new Player { Name = "Aaron Rodgers", Stats = 4000, Description = "Experienced quarterback with precision passing skills.", Photo = "aaron_rodgers.png", Age = 40, Team = teams[24], Position = position[0] };
            var p3 = new Player { Name = "Tom Brady", Stats = 4600, Description = "Legendary quarterback with multiple Super Bowl titles.", Photo = "tom_brady.png", Age = 46, Team = teams[21], Position = position[0] };
            var p4 = new Player { Name = "Dak Prescott", Stats = 4000, Description = "Dual-threat quarterback known for his leadership.", Photo = "dak_prescott.png", Age = 30, Team = teams[8], Position = position[0] };
            var p5 = new Player { Name = "Josh Allen", Stats = 4500, Description = "Strong-armed quarterback with rushing ability.", Photo = "josh_allen.png", Age = 27, Team = teams[3], Position = position[0] };
            var p6 = new Player { Name = "Derrick Henry", Stats = 1500, Description = "Powerful running back known for his speed and strength.", Photo = "derrick_henry.png", Age = 29, Team = teams[2], Position = position[1] };
            var p7 = new Player { Name = "Christian McCaffrey", Stats = 1400, Description = "Versatile running back with excellent receiving skills.", Photo = "christian_mccaffrey.png", Age = 28, Team = teams[27], Position = position[1] };
            var p8 = new Player { Name = "Ezekiel Elliott", Stats = 1000, Description = "Consistent running back with a strong track record.", Photo = "ezekiel_elliott.png", Age = 29, Team = teams[8], Position = position[1] };
            var p9 = new Player { Name = "Alvin Kamara", Stats = 900, Description = "Dynamic running back with great receiving skills.", Photo = "alvin_kamara.png", Age = 28, Team = teams[22], Position = position[1] };
            var p10 = new Player { Name = "Davante Adams", Stats = 1500, Description = "Elite wide receiver known for his route running.", Photo = "davante_adams.png", Age = 31, Team = teams[24], Position = position[2] };
            var p11 = new Player { Name = "Tyreek Hill", Stats = 1700, Description = "Explosive wide receiver with breakaway speed.", Photo = "tyreek_hill.png", Age = 30, Team = teams[19], Position = position[2] };
            var p12 = new Player { Name = "Stefon Diggs", Stats = 1500, Description = "Talented wide receiver with great hands.", Photo = "stefon_diggs.png", Age = 30, Team = teams[12], Position = position[2] };
            var p13 = new Player { Name = "DeAndre Hopkins", Stats = 1400, Description = "Outstanding receiver with great catch radius.", Photo = "deandre_hopkins.png", Age = 31, Team = teams[30], Position = position[2] };
            var p14 = new Player { Name = "George Kittle", Stats = 1000, Description = "Top tight end known for his blocking and receiving.", Photo = "george_kittle.png", Age = 30, Team = teams[27], Position = position[3] };
            var p15 = new Player { Name = "Travis Kelce", Stats = 1200, Description = "Dynamic tight end with great receiving skills.", Photo = "travis_kelce.png", Age = 34, Team = teams[15], Position = position[3] };
            var p16 = new Player { Name = "Mark Andrews", Stats = 1000, Description = "Prolific tight end with good route running.", Photo = "mark_andrews.png", Age = 28, Team = teams[2], Position = position[3] };
            var p17 = new Player { Name = "Darren Waller", Stats = 900, Description = "Athletic tight end known for his big plays.", Photo = "darren_waller.png", Age = 31, Team = teams[23], Position = position[3] };
            var p18 = new Player { Name = "Justin Jefferson", Stats = 1600, Description = "Young star receiver known for his big-play ability.", Photo = "justin_jefferson.png", Age = 25, Team = teams[20], Position = position[2] };
            var p19 = new Player { Name = "A.J. Brown", Stats = 1300, Description = "Strong wide receiver with good catching ability.", Photo = "aj_brown.png", Age = 26, Team = teams[25], Position = position[2] };

            return new List<Player>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19 };
        }

        private List<Team> GetTeams()
        {
            return
            [
            new Team { Name = "Arizona Cardinals", Logo = "cardinals.png", Colours = "Cardinal Red, White", Mascot = "Big Red", Stadium = "state_farm_stadium.png", Date_founded = new DateTime(1898, 1, 1), City = "Glendale" },
            new Team { Name = "Atlanta Falcons", Logo = "falcons.png", Colours = "Black, Red", Mascot = "Freddie Falcon", Stadium = "mercedes_benz_stadium.png", Date_founded = new DateTime(1965, 1, 1), City = "Atlanta" },
            new Team { Name = "Baltimore Ravens", Logo = "ravens.png", Colours = "Purple, Black", Mascot = "Poe", Stadium = "mt_bank_stadium.png", Date_founded = new DateTime(1996, 1, 1), City = "Baltimore" },
            new Team { Name = "Buffalo Bills", Logo = "bills.png", Colours = "Royal Blue, Red", Mascot = "Billy Buffalo", Stadium = "highmark_stadium.png", Date_founded = new DateTime(1960, 1, 1), City = "Buffalo" },
            new Team { Name = "Carolina Panthers", Logo = "panthers.png", Colours = "Black, Blue", Mascot = "Sir Purr", Stadium = "bank_of_america_stadium.png", Date_founded = new DateTime(1993, 1, 1), City = "Charlotte" },
            new Team { Name = "Chicago Bears", Logo = "bears.png", Colours = "Navy Blue, Orange", Mascot = "Staley Da Bear", Stadium = "soldier_field.png", Date_founded = new DateTime(1919, 1, 1), City = "Chicago" },
            new Team { Name = "Cincinnati Bengals", Logo = "bengals.png", Colours = "Black, Orange", Mascot = "Who Dey", Stadium = "paycor_stadium.png", Date_founded = new DateTime(1968, 1, 1), City = "Cincinnati" },
            new Team { Name = "Cleveland Browns", Logo = "browns.png", Colours = "Brown, Orange", Mascot = "Brownie the Elf", Stadium = "firstenergy_stadium.png", Date_founded = new DateTime(1946, 1, 1), City = "Cleveland" },
            new Team { Name = "Dallas Cowboys", Logo = "cowboys.png", Colours = "Navy Blue, Silver", Mascot = "Rowdy", Stadium = "atandt_stadium.png", Date_founded = new DateTime(1960, 1, 1), City = "Arlington" },
            new Team { Name = "Denver Broncos", Logo = "broncos.png", Colours = "Orange, Navy Blue", Mascot = "Miles", Stadium = "empower_field_at_mile_high.png", Date_founded = new DateTime(1960, 1, 1), City = "Denver" },
            new Team { Name = "Detroit Lions", Logo = "lions.png", Colours = "Honolulu Blue, Silver", Mascot = "Roary", Stadium = "ford_field.png", Date_founded = new DateTime(1930, 1, 1), City = "Detroit" },
            new Team { Name = "Green Bay Packers", Logo = "packers.png", Colours = "Green, Gold", Mascot = "None", Stadium = "lambeau_field.png", Date_founded = new DateTime(1919, 1, 1), City = "Green Bay" },
            new Team { Name = "Houston Texans", Logo = "texans.png", Colours = "Deep Steel Blue, Battle Red", Mascot = "Toro", Stadium = "nrg_stadium.png", Date_founded = new DateTime(2002, 1, 1), City = "Houston" },
            new Team { Name = "Indianapolis Colts", Logo = "colts.png", Colours = "Royal Blue, White", Mascot = "Blue", Stadium = "lucas_oil_stadium.png", Date_founded = new DateTime(1953, 1, 1), City = "Indianapolis" },
            new Team { Name = "Jacksonville Jaguars", Logo = "jaguars.png", Colours = "Teal, Black", Mascot = "Jaxson de Ville", Stadium = "tiaa_bank_field.png", Date_founded = new DateTime(1995, 1, 1), City = "Jacksonville" },
            new Team { Name = "Kansas City Chiefs", Logo = "chiefs.png", Colours = "Red, Gold", Mascot = "K.C. Wolf", Stadium = "geha_field_at_arrowhead_stadium.png", Date_founded = new DateTime(1960, 1, 1), City = "Kansas City" },
            new Team { Name = "Las Vegas Raiders", Logo = "raiders.png", Colours = "Silver, Black", Mascot = "Raider Rusher", Stadium = "allegiant_stadium.png", Date_founded = new DateTime(1960, 1, 1), City = "Las Vegas" },
            new Team { Name = "Los Angeles Chargers", Logo = "chargers.png", Colours = "Navy Blue, Gold", Mascot = "Boltman", Stadium = "sofi_stadium.png", Date_founded = new DateTime(1960, 1, 1), City = "Los Angeles" },
            new Team { Name = "Los Angeles Rams", Logo = "rams.png", Colours = "Royal Blue, Gold", Mascot = "Rampage", Stadium = "sofi_stadium.png", Date_founded = new DateTime(1936, 1, 1), City = "Los Angeles" },
            new Team { Name = "Miami Dolphins", Logo = "dolphins.png", Colours = "Aqua, Orange", Mascot = "T.D. the Dolphin", Stadium = "hard_rock_stadium.png", Date_founded = new DateTime(1966, 1, 1), City = "Miami" },
            new Team { Name = "Minnesota Vikings", Logo = "vikings.png", Colours = "Purple, Gold", Mascot = "Viktor the Viking", Stadium = "us_bank_stadium.png", Date_founded = new DateTime(1960, 1, 1), City = "Minneapolis" },
            new Team { Name = "New England Patriots", Logo = "patriots.png", Colours = "Navy Blue, Red", Mascot = "Pat Patriot", Stadium = "gillette_stadium.png", Date_founded = new DateTime(1960, 1, 1), City = "Foxborough" },
            new Team { Name = "New Orleans Saints", Logo = "saints.png", Colours = "Black, Gold", Mascot = "Gumbo", Stadium = "caesar_superdome.png", Date_founded = new DateTime(1967, 1, 1), City = "New Orleans" },
            new Team { Name = "New York Giants", Logo = "giants.png", Colours = "Royal Blue, Red", Mascot = "None", Stadium = "metlife_stadium.png", Date_founded = new DateTime(1925, 1, 1), City = "East Rutherford" },
            new Team { Name = "New York Jets", Logo = "jets.png", Colours = "Green, White", Mascot = "None", Stadium = "metlife_stadium.png", Date_founded = new DateTime(1959, 1, 1), City = "East Rutherford" },
            new Team { Name = "Philadelphia Eagles", Logo = "eagles.png", Colours = "Midnight Green, Silver", Mascot = "Swoop", Stadium = "lincoln_financial_field.png", Date_founded = new DateTime(1933, 1, 1), City = "Philadelphia" },
            new Team { Name = "Pittsburgh Steelers", Logo = "steelers.png", Colours = "Black, Gold", Mascot = "Steely McBeam", Stadium = "acri_sure_stadium.png", Date_founded = new DateTime(1933, 1, 1), City = "Pittsburgh" },
            new Team { Name = "San Francisco 49ers", Logo = "49ers.png", Colours = "Scarlet Red, Gold", Mascot = "Sourdough Sam", Stadium = "levi_stadium.png", Date_founded = new DateTime(1946, 1, 1), City = "Santa Clara" },
            new Team { Name = "Seattle Seahawks", Logo = "seahawks.png", Colours = "Navy, Green", Mascot = "Blitz", Stadium = "lumen_field.png", Date_founded = new DateTime(1976, 1, 1), City = "Seattle" },
            new Team { Name = "Tampa Bay Buccaneers", Logo = "buccaneers.png", Colours = "Red, Black", Mascot = "Captain Fear", Stadium = "raymond_james_stadium.png", Date_founded = new DateTime(1976, 1, 1), City = "Tampa" },
            new Team { Name = "Tennessee Titans", Logo = "titans.png", Colours = "Navy, Titans Blue", Mascot = "T-Rac", Stadium = "nissan_stadium.png", Date_founded = new DateTime(1960, 1, 1), City = "Nashville" },
            new Team { Name = "Washington Commanders", Logo = "commanders.png", Colours = "Burgundy, Gold", Mascot = "Major Tuddy", Stadium = "fedex_field.png", Date_founded = new DateTime(1932, 1, 1),City = "Landover"}
            ];
        }

        private List<Position> GetPosition()
        {
            return
            [
                new Position { Name = "Quarterback"},
                new Position { Name = "Running Back"},
                new Position { Name = "Wide Reciever"},
                new Position { Name = "Tight End"}
            ];
        }
    }
}
