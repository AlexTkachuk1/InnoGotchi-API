using InnoGotchi.BLL.Interfaces;
using InnoGotchi.BLL.Services;
using InnoGotchi.DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InnoGotchi.BLL
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddBLLInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserService>(container =>
            new UserService(container.GetService<IUnitOfWork>())
            );

            return services;
        }
    }
}
