using BuildingBlocks.Exceptions.Handler;
using BuildingBlocks.Extensions;
using FluentValidation;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Configuration;

namespace Ordering.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
    {
        var assembly = typeof(Program).Assembly;
        services.AddCarterWithAssembly(assembly);

        services.AddExceptionHandler<CustomExceptionHandler>();
        services.AddHealthChecks()
            .AddSqlServer(configuration.GetConnectionString("Database")!);

        return services;
    }

    public static WebApplication UseApi(this WebApplication app)
    {
        app.MapCarter();

        app.UseExceptionHandler(options => { });
        app.UseHealthChecks("/health",
            new HealthCheckOptions
            {
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

        return app;
    }
}