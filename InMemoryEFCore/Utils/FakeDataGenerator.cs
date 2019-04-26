using System;
using System.Linq;
using InMemoryEFCore.DataContext;
using InMemoryEFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InMemoryEFCore.Utils
{
    public class FakeDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CityGuideDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<CityGuideDBContext>>()))
            {
                // Look for any points of interest already in database
                if (context.PointsOfInterest.Any())
                {
                    return; // Database has been seeded
                }

                context.PointsOfInterest.AddRange(
                    new PointOfInterest()
                    {
                        Id = 1,
                        Name = "Monastery of Jerónimos"
                    },
                    new PointOfInterest()
                    {
                        Id = 2,
                        Name = "Belém Tower"
                    });

                context.SaveChanges();
            }
        }
    }
}
