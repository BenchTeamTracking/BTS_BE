using BTS.Domain.Core.User;
using BTS.Infrastructure;
using BTS.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BTS_BE.Configuration
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            //add scopes here for DI
            services.AddScoped<IUserRepository, UserRepository>();

            //appsettings configuration
            var appsettings = configuration.GetSection("AppConfiguration");
            services.Configure<Appconfiguration>(appsettings);

            services.AddDbContext<DataContext>(options => options.UseSqlServer(appsettings["ConnectionString"]));

            return services;
        }
    }
}
