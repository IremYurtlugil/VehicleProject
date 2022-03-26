using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WebApp.DataOperations.Context;
using WebApp.Entities.Concrete;
using WebApp.Entities.Enum;

namespace WebApp.DataOperations.DataGenerator
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VehicleDbContext(serviceProvider.GetRequiredService<DbContextOptions<VehicleDbContext>>()))
            {
                if (context.Cars.Any())
                    return;
                else
                {
                    context.Cars.AddRange(
                        new Car
                        {
                            Id = 1,
                            Brand = "Nissan",
                            Color = ColorType.black,
                        },
                        new Car
                        {
                            Id = 2,
                            Brand = "Opel",
                            Color = ColorType.blue
                        },
                        new Car
                        {
                            Id = 3,
                            Brand = "Ford",
                            Color = ColorType.red
                        },
                        new Car
                        {
                            Id = 4,
                            Brand = "Wolksvagen",
                            Color = ColorType.white
                        },
                        new Car
                        {
                            Id = 5,
                            Brand = "Renault",
                            Color = ColorType.yellow
                        },
                        new Car
                        {
                            Id = 6,
                            Brand = "Opel",
                            Color = ColorType.orange
                        },
                         new Car
                         {
                             Id = 7,
                             Brand = "Audi",
                             Color = ColorType.pink
                         },
                         new Car
                         {
                             Id = 8,
                             Brand = "Jeep",
                             Color = ColorType.black
                         },
                         new Car
                         {
                             Id = 9,
                             Brand = "Mazda",
                             Color = ColorType.grey
                         },
                          new Car
                          {
                              Id = 10,
                              Brand = "Mercedes",
                              Color = ColorType.white
                          },
                           new Car
                           {
                               Id = 11,
                               Brand = "Seat",
                               Color = ColorType.red
                           }
                        );

                    context.Buses.AddRange(
                        new Bus
                        {
                            Id = 1,
                            Brand = "Mercedes",
                            Color = ColorType.black
                        },
                        new Bus
                        {
                            Id = 2,
                            Brand = "Opel",
                            Color = ColorType.blue
                        },
                        new Bus
                        {
                            Id = 3,
                            Brand = "Ford",
                            Color = ColorType.red
                        },
                        new Bus
                        {
                            Id = 4,
                            Brand = "Wolksvagen",
                            Color = ColorType.white
                        },
                         new Bus
                         {
                             Id = 5,
                             Brand = "Hyundai",
                             Color = ColorType.orange
                         },
                          new Bus
                          {
                              Id = 6,
                              Brand = "Isuzu",
                              Color = ColorType.grey
                          },
                           new Bus
                           {
                               Id = 7,
                               Brand = "Iveco",
                               Color = ColorType.white
                           });

                    context.Boats.AddRange(
                        new Boat
                        {
                            Id = 1,
                            Brand = "Barracuda",
                            Color = ColorType.black
                        },
                        new Boat
                        {
                            Id = 2,
                            Brand = "GTS 225",
                            Color = ColorType.blue
                        },
                        new Boat
                        {
                            Id = 3,
                            Brand = "GTS 205",
                            Color = ColorType.red
                        },
                        new Boat
                        {
                            Id = 4,
                            Brand = "Quicksilver Activ 755 Weekend",
                            Color = ColorType.white
                        },
                        new Boat
                        {
                            Id = 5,
                            Brand = "Merry Fisher 895",
                            Color = ColorType.grey
                        },
                        new Boat
                        {
                            Id = 6,
                            Brand = "Barracuda 8",
                            Color = ColorType.red
                        },
                        new Boat
                        {
                            Id = 7,
                            Brand = "Quicksilver 905 Pilothouse",
                            Color = ColorType.blue
                        },
                           new Boat
                           {
                               Id = 8,
                               Brand = "Jeanneau Cap Camarat 10.5 Walk Around",
                               Color = ColorType.white
                           }
                        );

                    context.SaveChanges();
                }

            }
        }
    }
}
