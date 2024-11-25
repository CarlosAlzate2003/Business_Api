using Microsoft.Extensions.DependencyInjection;
using ProyectoEF.interfaces;
using ProyectoEF.Repositories;

namespace ProyectoEF.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IUsuarioInterface, UsuarioRepository>();
        services.AddScoped<IAuthInterface, AuthRepository>();

        return services;
    }
}