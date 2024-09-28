
using CleanArchi.Core.Models;

namespace CleanArchi.Core.Interfaces
{
    public interface IExternalApiRepo
    {
        Task<CoindeskData> GetCoins();
    }
}
