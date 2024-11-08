using UniverseModeTracker.Application.Mapping;
using UniverseModeTracker.DataAccess.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


namespace UniverseModeTracker.API.Extensions;

public static class ServiceConfigurationsExtensions
{
    public static IServiceCollection AddGeneralServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "Universe Mode Tracker API", Version = "v1" }));
        services.AddAutoMapper(typeof(MappingProfile));
        services.AddDbContext<DefaultDataContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}