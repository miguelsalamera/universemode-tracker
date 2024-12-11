using UniverseModeTracker.DataAccess.Repositories.Interfaces;
using UniverseModeTracker.DataAccess.Repositories.Implementations;
using UniverseModeTracker.Application.Services.Implementations;
using UniverseModeTracker.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace UniverseModeTracker.API.Extensions;

public static class DependencyInjectionExtensions 
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ISuperstarService, SuperstarService>();
        services.AddScoped<IMatchService, MatchService>();
        services.AddScoped<IBrandService, BrandService>();

        services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); 
        services.AddScoped<ISuperstarRepository, SuperstarRepository>();
        services.AddScoped<IMatchRepository, MatchRepository>();
        services.AddScoped<ICornerRepository, CornerRepository>();
        services.AddScoped<ICompetitorRepository, CompetitorRepository>();
        services.AddScoped<IShowRepository, ShowRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();

        return services;
    }
}