using CleanArchi.Core.Interfaces;
using CleanArchi.Core.Models;
using System.Net.Http.Json;


namespace CleanArchi.Infrastructure.Services
{
    public class CoindeskHttpClientService(HttpClient _httpClient): ICoindeskHttpClientService
    {
        public async Task<dynamic> GetData()
        {
            return await _httpClient.GetFromJsonAsync<CoindeskData>("bpi/currentprice.json");
        }
    }
}
