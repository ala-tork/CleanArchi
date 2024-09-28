using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchi.Core.Interfaces
{
    public interface ICoindeskHttpClientService
    {
        Task<dynamic> GetData();
    }
}
