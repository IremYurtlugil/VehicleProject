using Microsoft.EntityFrameworkCore;
using WebApp.Entities.Concrete;

namespace WebApp.DataOperations.Context
{
    public interface IVehicleDbContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<Boat> Boats { get; set; }
        DbSet<Bus> Buses { get; set; }
        int SaveChanges();
    }
}
