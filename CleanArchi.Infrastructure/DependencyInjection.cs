using CleanArchi.Core.Interfaces;
using CleanArchi.Infrastructure.Data;
using CleanArchi.Infrastructure.Repository;
using CleanArchi.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchi.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("localDb"));
            });
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<IExternalApiRepo , ExternalApiRepo>();

            services.AddAutoMapper(typeof(DependencyInjection).Assembly);
            services.AddHttpClient<ICoindeskHttpClientService,CoindeskHttpClientService>(op =>
            {
                op.BaseAddress= new Uri("https://api.coindesk.com/v1/");
            });
            return services;
        }
    }
}
