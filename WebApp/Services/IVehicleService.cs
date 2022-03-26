using System.Collections.Generic;
using WebApp.DTOs;

namespace WebApp.Services
{
    public interface IVehicleService
    {
        List<CarDTO> GetCars(string color = null);
        List<BusDTO> GetBuses(string color = null);
        List<BoatDTO> GetBoats(string color = null);
        CarDTO SwitchHeadLight(int carId, bool headlightState);
        void DeleteCar(int carId);

    }
}
