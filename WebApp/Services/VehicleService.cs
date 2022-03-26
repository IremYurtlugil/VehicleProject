using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.DataOperations.Context;
using WebApp.DTOs;
using WebApp.Entities.Concrete;
using WebApp.Entities.Enum;

namespace WebApp.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleDbContext context;

        public VehicleService(IVehicleDbContext context)
        {
            this.context = context;
        }

        public void DeleteCar(int carId)
        {
            var car = context.Cars.SingleOrDefault(c => c.Id == carId);
            if (car == null)
                throw new Exception("Car could not be found");
            context.Cars.Remove(car);
            context.SaveChanges();
        }

        public List<BoatDTO> GetBoats(string color = null)
        {
            List<Boat> boatList = null;
            if (color == null)
            {
                boatList = context.Boats.ToList();
            }
            else
            {
                var colorValue = (ColorType)Enum.Parse(typeof(ColorType), color);
                boatList = context.Boats.Where(c => c.Color == colorValue).ToList();
            }
            List<BoatDTO> apiList = new List<BoatDTO>();
            BoatDTO boat;
            foreach (var boatItem in boatList)
            {
                boat = new BoatDTO
                {
                    Id = boatItem.Id,
                    Brand = boatItem.Brand,
                    Color = boatItem.Color.ToString("F"),

                };
                apiList.Add(boat);
            }

            return apiList;
        }

        public List<BusDTO> GetBuses(string color = null)
        {
            List<Bus> busList = null;
            if (color == null)
            {
                busList = context.Buses.ToList();
            }
            else
            {
                var colorValue = (ColorType)Enum.Parse(typeof(ColorType), color);
                busList = context.Buses.Where(c => c.Color == colorValue).ToList();
            }
            List<BusDTO> apiList = new List<BusDTO>();
            BusDTO bus;
            foreach (var busItem in busList)
            {
                bus = new BusDTO
                {
                    Id = busItem.Id,
                    Brand = busItem.Brand,
                    Color = busItem.Color.ToString("F"),

                };
                apiList.Add(bus);
            }

            return apiList;
        }

        public List<CarDTO> GetCars(string color = null)
        {
            List<Car> carList = null;
            if (color == null)
            {
                carList = context.Cars.ToList();
            }
            else
            {
                var colorValue = (ColorType)Enum.Parse(typeof(ColorType), color);
                carList = context.Cars.Where(c => c.Color == colorValue).ToList();
            }
            List<CarDTO> apiList = new List<CarDTO>();
            CarDTO car;
            foreach (var carItem in carList)
            {
                car = new CarDTO
                {
                    Id = carItem.Id,
                    Brand = carItem.Brand,
                    Color = carItem.Color.ToString("F"),
                    Headlights = (carItem.Headlight) ? "Open" : "Closed"

                };
                apiList.Add(car);
            }

            return apiList;

        }

        public CarDTO SwitchHeadLight(int carId, bool headlightState)
        {
            var car = context.Cars.SingleOrDefault(c => c.Id == carId);
            if (car == null)
                throw new Exception("Car could not be found");
            car.Headlight = headlightState;
            context.SaveChanges();

            var result = new CarDTO
            {
                Id = car.Id,
                Brand = car.Brand,
                Color = car.Color.ToString("F"),
                Headlights = (car.Headlight) ? "Open" : "Closed"
            };

            return result;

        }
    }
}
