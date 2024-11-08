using Serilog;

public static class HostBuilderExtensions
{
    public static IHostBuilder ConfigureSerilogLogging(this IHostBuilder hostBuilder)
    {
        return hostBuilder.UseSerilog((context, services, configuration) =>
        {
            configuration
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File(Path.Combine(AppContext.BaseDirectory, "logs"), rollingInterval: RollingInterval.Day)
                .Enrich.FromLogContext();
        });
    }
}