using Microsoft.AspNetCore.Mvc;
using System;
using WebApp.Entities.Enum;
using WebApp.Services;

namespace WebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        private readonly IVehicleService service;

        public VehiclesController(IVehicleService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult GetCars()
        {
            var cars = service.GetCars();
            return Ok(cars);
        }
        [HttpGet("{color}")]
        public IActionResult GetCarsByColor(string color)
        {
            if (!String.IsNullOrEmpty(color)) color = color.Trim().ToLower();
            else return NotFound("Write a color to filter cars");
            if (ColorType.IsDefined(typeof(ColorType), color))
            {
                var carsByColor = service.GetCars(color);
                return Ok(carsByColor);
            }
            return BadRequest("There is not any car with this color.");

        }

        [HttpGet("{color}")]
        public IActionResult GetBusesByColor(string color)
        {
            if (!String.IsNullOrEmpty(color)) color = color.Trim().ToLower();
            else return NotFound("Write a color to filter buses");
            if (ColorType.IsDefined(typeof(ColorType), color))
            {
                var busesByColor = service.GetBuses(color);
                return Ok(busesByColor);
            }
            return BadRequest("There is not any bus with this color.");

        }

        [HttpGet("{color}")]
        public IActionResult GetBoatsByColor(string color)
        {
            if (!String.IsNullOrEmpty(color)) color = color.Trim().ToLower();
            else return NotFound("Write a color to filter boats");
            if (ColorType.IsDefined(typeof(ColorType), color))
            {
                var boatsByColor = service.GetBoats(color);
                return Ok(boatsByColor);
            }
            return BadRequest("There is not any boat with this color.");

        }

        [HttpPut("{id}")]
        public IActionResult StateOfHeadlight(int id, [FromBody] bool headlightState)
        {
            try
            {
                var result = service.SwitchHeadLight(id, headlightState);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            #region Before
            //var car = context.Cars.SingleOrDefault(m => m.Id == id);
            //if (car == null)
            //    return BadRequest("Car is not found on database");
            //context.Cars.Remove(car);
            //context.SaveChanges();
            //return Ok($"{car.Brand} - {car.Color} is deleted"); 
            #endregion

            try
            {
                service.DeleteCar(id);
                return Ok("Car is deleted.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
