using Microsoft.EntityFrameworkCore;
using NFLRookieGuide.Model;

namespace NFLRookieGuide.Context
{
    public class APIService
    {
        private readonly HttpClient _httpClient;
        public APIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        private readonly DatabaseContext _context;
        public async Task<T?> GetAsync<T>()
        {
            return await _httpClient.GetFromJsonAsync<T>("https://api.sportradar.com/nfl/official/trial/v7/en/players/11cad59d-90dd-449c-a839-dddaba4fe16c/profile.json?api_key=r3wGOsDopCEioyNnxFdeMEM0D0hZn4fOJeyg5VLZ");
        }
        //"+_context.Player.ApiId+"

        //public async Task<List<Team>> GetAllTeamsAsync()
        //{
        //    return await _context.Teams.OrderBy(team => team.Name).ToListAsync();
        //} 

        //public Team? GetTeam(int id)
        //{
        //    return _context.Teams.Find(id);
        //}
    }
}
