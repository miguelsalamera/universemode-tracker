using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace UniverseModeTracker.API.Extensions;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder UseMiddlewares(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Universe Mode Tracker API v1");
            });
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        return app;
    }
}