using CleanArchi.Core.Interfaces;
using CleanArchi.Core.Models;

namespace CleanArchi.Infrastructure.Repository
{
    public class ExternalApiRepo(ICoindeskHttpClientService service) : IExternalApiRepo
    {
        public async Task<CoindeskData> GetCoins()
        {
            return await service.GetData();
        }
    }
}
