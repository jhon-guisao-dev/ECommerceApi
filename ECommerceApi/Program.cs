using ECommerceApi;
using ECommerceApi.Data;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var contextFactory = services.GetRequiredService<IDbContextFactory<DataContext>>();
            using var context = contextFactory.CreateDbContext();
            context.Database.EnsureCreated();
            var initializer = services.GetRequiredService<DbInitializer>();
            await initializer.Initialize(context);
        }

        host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
