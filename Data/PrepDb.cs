//rawan
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using PlatformService.Models;
namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetRequiredService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data...");
                context.Platforms.AddRange(
                    new Platform()
                    {
                        Name="Dot Net",
                        Publisher="Microsoft",
                        Cost="Free"
                    },
                    new Platform()
                    {
                        Name="SQL Server Express",
                        Publisher="Microsoft",
                        Cost="Free"
                    },
                    new Platform()
                    {
                        Name="Kubernetes",
                        Publisher="Cloud Native Computing Foundation",
                        Cost="Free"
                    }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> we already have data");
            }
        }
    }
}
//https://github.com/rawan2610/.NET-Microservices-Jackson-Course.git