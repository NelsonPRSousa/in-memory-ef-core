using InMemoryEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryEFCore.DataContext
{
    public class CityGuideDBContext : DbContext
    {
        public CityGuideDBContext(DbContextOptions<CityGuideDBContext> options) : base(options)
        {
        }

        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
    }
}
