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
            } //fills the database with values from the GetTeams method 

            if (!_context.Positions.Any())
            {
                _context.Positions.AddRange(positions);
                await _context!.SaveChangesAsync();
            }

            if (!_context.Plays.Any())
            {
                var plays = GetPlays(positions); //passes positions so they can be used here
                _context.Plays.AddRange(plays); //adds the plays made
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
            var p14 = new Player { Name = "George Kittle", Stats = 1000, Description = "Top tight end known for his blocking and receiving.", Photo = "george_kittle.png", Age = 30, Team = teams[27], Position = position[4] };
            var p15 = new Player { Name = "Travis Kelce", Stats = 1200, Description = "Dynamic tight end with great receiving skills.", Photo = "travis_kelce.png", Age = 34, Team = teams[15], Position = position[4] };
            var p16 = new Player { Name = "Mark Andrews", Stats = 1000, Description = "Prolific tight end with good route running.", Photo = "mark_andrews.png", Age = 28, Team = teams[2], Position = position[4] };
            var p17 = new Player { Name = "Darren Waller", Stats = 900, Description = "Athletic tight end known for his big plays.", Photo = "darren_waller.png", Age = 31, Team = teams[23], Position = position[3] };
            var p18 = new Player { Name = "Justin Jefferson", Stats = 1600, Description = "Young star receiver known for his big-play ability.", Photo = "justin_jefferson.png", Age = 25, Team = teams[20], Position = position[2] };
            var p19 = new Player { Name = "A.J. Brown", Stats = 1300, Description = "Strong wide receiver with good catching ability.", Photo = "aj_brown.png", Age = 26, Team = teams[25], Position = position[2] };

            return new List<Player>() { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19 };
        }

        private List<Team> GetTeams()
        {
            return
            [
           new Team { Name = "Arizona Cardinals", Logo = "cardinals.png", Colours = "Red , White", Mascot = "Big_Red.jpg", Stadium = "state_farm_stadium.jpg", Date_founded = new DateTime(1898, 1, 1), City = "Glendale" },
           new Team { Name = "Atlanta Falcons", Logo = "falcons.png", Colours = "Black , Red", Mascot = "Freddie_Falcon.jpg", Stadium = "mercedes_benz_stadium.jpg", Date_founded = new DateTime(1965, 1, 1), City = "Atlanta" },
           new Team { Name = "Baltimore Ravens", Logo = "ravens.png", Colours = "Purple , Black", Mascot = "Poe.jpg", Stadium = "mt_bank_stadium.jpg", Date_founded = new DateTime(1996, 1, 1), City = "Baltimore" },
           new Team { Name = "Buffalo Bills", Logo = "bills.png", Colours = "Blue , Red", Mascot = "Billy_Buffalo.jpg", Stadium = "highmark_stadium.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Buffalo" },
           new Team { Name = "Carolina Panthers", Logo = "panthers.png", Colours = "Black , Blue", Mascot = "Sir_Purr.jpg", Stadium = "bank_of_america_stadium.jpg", Date_founded = new DateTime(1993, 1, 1), City = "Charlotte" },
           new Team { Name = "Chicago Bears", Logo = "bears.png", Colours = "Blue , Orange", Mascot = "Staley_Da_Bear.jpg", Stadium = "soldier_field.jpg", Date_founded = new DateTime(1919, 1, 1), City = "Chicago" },
           new Team { Name = "Cincinnati Bengals", Logo = "bengals.png", Colours = "Black , Orange", Mascot = "Who_Dey.jpg", Stadium = "paycor_stadium.jpg", Date_founded = new DateTime(1968, 1, 1), City = "Cincinnati" },
           new Team { Name = "Cleveland Browns", Logo = "browns.png", Colours = "Brown , Orange", Mascot = "Brownie_the_Elf.jpg", Stadium = "firstenergy_stadium.jpg", Date_founded = new DateTime(1946, 1, 1), City = "Cleveland" },
           new Team { Name = "Dallas Cowboys", Logo = "cowboys.png", Colours = "Blue , Silver", Mascot = "Rowdy.jpg", Stadium = "atandt_stadium.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Arlington" },
           new Team { Name = "Denver Broncos", Logo = "broncos.png", Colours = "Orange , Navy Blue", Mascot = "Miles.jpg", Stadium = "empower_field_at_mile_high.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Denver" },
           new Team { Name = "Detroit Lions", Logo = "lions.png", Colours = "Blue , Silver", Mascot = "Roary.jpg", Stadium = "ford_field.jpg", Date_founded = new DateTime(1930, 1, 1), City = "Detroit" },
           new Team { Name = "Green Bay Packers", Logo = "packers.png", Colours = "Green , Gold", Mascot = "None.jpg", Stadium = "lambeau_field.jpg", Date_founded = new DateTime(1919, 1, 1), City = "Green Bay" },
           new Team { Name = "Houston Texans", Logo = "texans.png", Colours = "Blue , Battle Red", Mascot = "Toro.jpg", Stadium = "nrg_stadium.jpg", Date_founded = new DateTime(2002, 1, 1), City = "Houston" },
           new Team { Name = "Indianapolis Colts", Logo = "colts.png", Colours = "Blue , White", Mascot = "Blue.jpg", Stadium = "lucas_oil_stadium.jpg", Date_founded = new DateTime(1953, 1, 1), City = "Indianapolis" },
           new Team { Name = "Jacksonville Jaguars", Logo = "jaguars.png", Colours = "Teal , Black", Mascot = "Jaxson_de_Ville.jpg", Stadium = "tiaa_bank_field.jpg", Date_founded = new DateTime(1995, 1, 1), City = "Jacksonville" },
           new Team { Name = "Kansas City Chiefs", Logo = "chiefs.png", Colours = "Red , Gold", Mascot = "K.C._Wolf.jpg", Stadium = "geha_field_at_arrowhead_stadium.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Kansas City" },
           new Team { Name = "Las Vegas Raiders", Logo = "raiders.png", Colours = "Grey , Black", Mascot = "Raider_Rusher.jpg", Stadium = "allegiant_stadium.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Las Vegas" },
           new Team { Name = "Los Angeles Chargers", Logo = "chargers.png", Colours = "Blue , Gold", Mascot = "Boltman.jpg", Stadium = "sofi_stadium.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Los Angeles" },
           new Team { Name = "Los Angeles Rams", Logo = "rams.png", Colours = "Blue , Gold", Mascot = "Rampage.jpg", Stadium = "sofi_stadium.jpg", Date_founded = new DateTime(1936, 1, 1), City = "Los Angeles" },
           new Team { Name = "Miami Dolphins", Logo = "dolphins.png", Colours = "Aqua , Orange", Mascot = "T.D._the_Dolphin.jpg", Stadium = "hard_rock_stadium.jpg", Date_founded = new DateTime(1966, 1, 1), City = "Miami" },
           new Team { Name = "Minnesota Vikings", Logo = "vikings.png", Colours = "Purple , Gold", Mascot = "Viktor_the_Viking.jpg", Stadium = "us_bank_stadium.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Minneapolis" },
           new Team { Name = "New England Patriots", Logo = "patriots.png", Colours = "Blue , Red", Mascot = "Pat_Patriot.jpg", Stadium = "gillette_stadium.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Foxborough" },
           new Team { Name = "New Orleans Saints", Logo = "saints.png", Colours = "Black , Gold", Mascot = "Gumbo.jpg", Stadium = "caesar_superdome.jpg", Date_founded = new DateTime(1967, 1, 1), City = "New Orleans" },
           new Team { Name = "New York Giants", Logo = "giants.png", Colours = "Blue , Red", Mascot = "None.jpg", Stadium = "metlife_stadium.jpg", Date_founded = new DateTime(1925, 1, 1), City = "East Rutherford" },
           new Team { Name = "New York Jets", Logo = "jets.png", Colours = "Green , White", Mascot = "None.jpg", Stadium = "metlife_stadium.jpg", Date_founded = new DateTime(1959, 1, 1), City = "East Rutherford" },
           new Team { Name = "Philadelphia Eagles", Logo = "eagles.png", Colours = "Green , Silver", Mascot = "Swoop.jpg", Stadium = "lincoln_financial_field.jpg", Date_founded = new DateTime(1933, 1, 1), City = "Philadelphia" },
           new Team { Name = "Pittsburgh Steelers", Logo = "steelers.png", Colours = "Black , Gold", Mascot = "Steely_McBeam.jpg", Stadium = "acri_sure_stadium.jpg", Date_founded = new DateTime(1933, 1, 1), City = "Pittsburgh" },
           new Team { Name = "San Francisco 49ers", Logo = "49ers.png", Colours = "Red , Gold", Mascot = "Sourdough_Sam.jpg", Stadium = "levi_stadium.jpg", Date_founded = new DateTime(1946, 1, 1), City = "Santa Clara" },
           new Team { Name = "Seattle Seahawks", Logo = "seahawks.png", Colours = "Blue , Green", Mascot = "Blitz.jpg", Stadium = "lumen_field.jpg", Date_founded = new DateTime(1976, 1, 1), City = "Seattle" },
           new Team { Name = "Tampa Bay Buccaneers", Logo = "buccaneers.png", Colours = "Red , Black", Mascot = "Captain_Fear.jpg", Stadium = "raymond_james_stadium.jpg", Date_founded = new DateTime(1976, 1, 1), City = "Tampa" },
           new Team { Name = "Tennessee Titans", Logo = "titans.png", Colours = "Blue , Titans Blue", Mascot = "T-Rac.jpg", Stadium = "nissan_stadium.jpg", Date_founded = new DateTime(1960, 1, 1), City = "Nashville" },
           new Team { Name = "Washington Commanders", Logo = "commanders.png", Colours = "Red , Gold", Mascot = "Major_Tuddy.jpg", Stadium = "fedex_field.jpg", Date_founded = new DateTime(1932, 1, 1), City = "Landover" }
            ];
        }
        private List<Play> GetPlays(List<Position> positions)
        {
            return 
                [
                new Play {Name="Inside Zone", Diagram ="InsideZone.jpg", Position1 = positions[2], Position2 = positions[3], Position3 = positions[0], Position6 = positions[4],Position9 = positions[1]},
                new Play {Name="Power O", Diagram ="PowerO.jpg", Position1 = positions[2], Position3 = positions[0], Position5 = positions[3],Position8 = positions[4],Position9= positions[1]},
                new Play {Name="Play Action", Diagram ="PlayAction.jpg", Position2 = positions[2], Position5 = positions[4],Position7 = positions[3], Position8=positions[0], Position9=positions[1]},
                new Play {Name="Four Vertical", Diagram ="FourVertical.jpg", Position1 = positions[2], Position9 = positions[0], Position5 = positions[4],Position8 = positions[1],Position7 = positions[3]},
                new Play {Name="CurlFlat", Diagram ="CurlFlat.jpg", Position1 = positions[2], Position2 = positions[3], Position8 = positions[0], Position4 = positions[4],Position9 = positions[1]},
                new Play {Name="Mesh", Diagram ="Mesh.png", Position1 = positions[2], Position4 = positions[3], Position8 = positions[0], Position5 = positions[4],Position9 = positions[1]},
                new Play {Name="Dagger", Diagram ="Dagger.jpg", Position1 = positions[2], Position2 = positions[3], Position3 = positions[0], Position5 = positions[4],Position8 = positions[1]},
                new Play {Name="Levels", Diagram ="Levels.jpg", Position1 = positions[2], Position6 = positions[3], Position9 = positions[0], Position5 = positions[4],Position8 = positions[1]},
                new Play {Name="Screen Pass", Diagram ="ScreenPass.jpg", Position6 = positions[2], Position5 = positions[3], Position9 = positions[0], Position1 = positions[4],Position8 = positions[1]}
                ];
        }

        private List<Position> GetPosition()
        {
            return
            [
                new Position { Name = "Quarterback"},
                new Position { Name = "Running Back"},
                new Position { Name = "Wide Reciever 1"},
                new Position { Name = "Wide Reciever 2"},
                new Position { Name = "Tight End"}
            ];
        }
    }
}
