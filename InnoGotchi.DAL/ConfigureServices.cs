using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Interfaces;
using InnoGotchi.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InnoGotchi.DAL
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddDALInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<InnoGotchiDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork>(container =>
            new EFUnitOfWork(container.GetService<InnoGotchiDbContext>())
            );

            return services;
        }
    }
}
