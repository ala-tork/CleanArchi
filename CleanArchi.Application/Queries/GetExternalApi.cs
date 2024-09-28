using CleanArchi.Core.Interfaces;
using CleanArchi.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchi.Application.Queries
{
    public record  GetExternalApi():IRequest<CoindeskData>;

    public class GetExternalApiHandler(IExternalApiRepo externalApi) : IRequestHandler<GetExternalApi, CoindeskData>
    {
        public async  Task<CoindeskData> Handle(GetExternalApi request, CancellationToken cancellationToken)
        {
            return await externalApi.GetCoins();
        }
    }
}
