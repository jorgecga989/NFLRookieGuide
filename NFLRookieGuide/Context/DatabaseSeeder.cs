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

            if(!_context.Player.Any())
            {
                var players = GetPlayers();
                _context.Player.AddRange(players);
                await _context!.SaveChangesAsync();
            }

            if (!_context.Teams.Any())
            {
                var teams = GetTeams();
                _context.Teams.AddRange(teams);
                await _context!.SaveChangesAsync();
            }

        }
        private List<Player> GetPlayers()
        {
            return
            [
             new Player { Name = "Patrick Mahomes", Stats = 4500, Description = "Dynamic quarterback with exceptional playmaking skills.", Photo = "patrick_mahomes.png", Age = 28,  },
            new Player { Name = "Josh Allen", Stats = 4000, Description = "Strong-armed quarterback known for his rushing ability.", Photo = "josh_allen.png", Age = 28,  },
            new Player { Name = "Aaron Rodgers", Stats = 3700, Description = "Veteran quarterback with a strong arm and leadership skills.", Photo = "aaron_rodgers.png", Age = 39,  },
            new Player { Name = "Dak Prescott", Stats = 3700, Description = "Accurate passer and dynamic leader on the field.", Photo = "dak_prescott.png", Age = 30, },
            new Player { Name = "Derrick Henry", Stats = 1500, Description = "Powerful running back known for breaking tackles.", Photo = "derrick_henry.png", Age = 30, },
            new Player { Name = "Saquon Barkley", Stats = 1400, Description = "Athletic running back with great speed and vision.", Photo = "saquon_barkley.png", Age = 27, },
            new Player { Name = "Christian McCaffrey", Stats = 1800, Description = "Versatile running back who excels in both rushing and receiving.", Photo = "christian_mccaffrey.png", Age = 27,  },
            new Player { Name = "Davante Adams", Stats = 1500, Description = "Elite wide receiver with exceptional route-running skills.", Photo = "davante_adams.png", Age = 31,  },
            new Player { Name = "Tyreek Hill", Stats = 1700, Description = "Explosive wide receiver known for his deep threats.", Photo = "tyreek_hill.png", Age = 30, },
            new Player { Name = "Stefon Diggs", Stats = 1500, Description = "Dynamic wide receiver with great hands and agility.", Photo = "stefon_diggs.png", Age = 30,  },
            new Player { Name = "Justin Jefferson", Stats = 1600, Description = "Young and talented wide receiver with incredible route running.", Photo = "justin_jefferson.png", Age = 25, },
            new Player { Name = "Travis Kelce", Stats = 1200, Description = "Top tight end known for his excellent receiving skills.", Photo = "travis_kelce.png", Age = 34, },
            new Player { Name = "George Kittle", Stats = 1000, Description = "Dynamic tight end with great athleticism and hands.", Photo = "george_kittle.png", Age = 30,  },
            new Player { Name = "Mark Andrews", Stats = 900, Description = "Talented tight end known for his reliable hands.", Photo = "mark_andrews.png", Age = 28,  },
            new Player { Name = "Kyle Pitts", Stats = 800, Description = "Rising star tight end with impressive athleticism.", Photo = "kyle_pitts.png", Age = 23, },
            new Player { Name = "A.J. Brown", Stats = 1200, Description = "Strong wide receiver with excellent yards after catch.", Photo = "aj_brown.png", Age = 26,  },
            new Player { Name = "DeAndre Hopkins", Stats = 1200, Description = "Proven wide receiver known for his incredible catching ability.", Photo = "deandre_hopkins.png", Age = 31,  },
            new Player { Name = "CeeDee Lamb", Stats = 1000, Description = "Talented wide receiver with great potential.", Photo = "ceedee_lamb.png", Age = 24,  },
            new Player { Name = "Chase Claypool", Stats = 800, Description = "Promising wide receiver with strong physicality.", Photo = "chase_claypool.png", Age = 25,  },
            new Player { Name = "Tua Tagovailoa", Stats = 3800, Description = "Young quarterback known for his accuracy and decision-making.", Photo = "tua_tagovailoa.png", Age = 26, }
            ];
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
            ];
        }
    }
}
