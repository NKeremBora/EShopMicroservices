using Carter;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BuildingBlocks.Extensions;


public static class CarterExtentions
{
    public static IServiceCollection AddCarterWithAssembly
        (this IServiceCollection services, Assembly assembly)
    {
        services.AddCarter(configurator: config =>
        {
            
                var modules = assembly.GetTypes()
                    .Where(t => t.IsAssignableTo(typeof(ICarterModule))).ToArray();

                config.WithModules(modules);
        });

        return services;
    }
}