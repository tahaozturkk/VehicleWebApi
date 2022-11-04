using Microsoft.EntityFrameworkCore;

namespace VehicleWebApi.Models.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Busses { get; set; }
    }
}
