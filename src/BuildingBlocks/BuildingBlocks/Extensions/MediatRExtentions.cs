using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using BuildingBlocks.Behaviors;
using System.Reflection;


namespace BuildingBlocks.Extensions;

public static class MediatRExtentions
{
    public static IServiceCollection AddMediatRWithAssembly
        (this IServiceCollection services, Assembly assembly)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(assembly);
            config.AddOpenBehavior(typeof(ValidationBehavior<,>));
            config.AddOpenBehavior(typeof(LoggingBehavior<,>));
        });
        
        return services;
    }
}