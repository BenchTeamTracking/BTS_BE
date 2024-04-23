using BTS.Application.Common;
using BTS.Application.Interfaces;
using BTS.Infrastructure.Data;
using BTS.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BTS_BE.Configuration
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration, WebApplicationBuilder builder)
        {
            //appsettings configuration
            var appsettings = configuration.GetSection("AppConfiguration");
            services.Configure<AppConfiguration>(appsettings);

            services.AddDbContext<DataContext>(options => options.UseSqlServer(appsettings["ConnectionString"]));

            //add scopes here for DI
            services.AddScoped<IUserRepository, UserRepository>();


            return services;
        }
    }
}
