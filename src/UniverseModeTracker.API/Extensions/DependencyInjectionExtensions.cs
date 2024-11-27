using UniverseModeTracker.DataAccess.Repositories.Interfaces;
using UniverseModeTracker.DataAccess.Repositories.Implementations;
using UniverseModeTracker.Application.Interfaces;
using UniverseModeTracker.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace UniverseModeTracker.API.Extensions;

public static class DependencyInjectionExtensions 
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ISuperstarService, SuperstarService>();

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); 
        services.AddScoped<ISuperstarRepository, SuperstarRepository>();

        return services;
    }
}