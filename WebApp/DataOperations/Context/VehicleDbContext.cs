using Microsoft.EntityFrameworkCore;
using WebApp.Entities.Concrete;

namespace WebApp.DataOperations.Context
{
    public class VehicleDbContext : DbContext, IVehicleDbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}
