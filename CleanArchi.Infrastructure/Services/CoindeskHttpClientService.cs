using CleanArchi.Core.Interfaces;
using CleanArchi.Core.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Json;


namespace CleanArchi.Infrastructure.Services
{
    public class CoindeskHttpClientService(HttpClient _httpClient): ICoindeskHttpClientService
    {
        public async Task<dynamic> GetData()
        {

            return await _httpClient.GetFromJsonAsync<CoindeskData>("bpi/currentprice.json");
        }

        public async Task<dynamic> GetData1()
        {
            var httpres = await _httpClient.GetAsync("bpi/currentprice.json");
            httpres.EnsureSuccessStatusCode();
            var res = await httpres.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CoindeskData>(res);

            //return await _httpClient.GetFromJsonAsync<CoindeskData>("bpi/currentprice.json");
        }
    }
}
