using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data;

public static class DbExtentions
{
    public static IApplicationBuilder UseMigration(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        var dbContext = serviceScope.ServiceProvider.GetService<DiscountContext>();
        dbContext.Database.MigrateAsync();
        
        return app;
    }
}