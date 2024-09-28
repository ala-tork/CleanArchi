using CleanArchi.Application;
using CleanArchi.Infrastructure;
namespace CleanArchi
{
    public static class AppDI
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddApplicationDI()
                .AddInfrastructureDI(configuration);
            return services;
        }
    }
}
