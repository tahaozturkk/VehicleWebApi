using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleWebApi.Models;
using VehicleWebApi.Models.Context;
using VehicleWebApi.Services.Abstract;

namespace VehicleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        readonly DatabaseContext _context;
        readonly ISelectVehicle _selectVehicle;

        public VehiclesController(DatabaseContext context, ISelectVehicle selectVehicle)
        {
            _context = context;
            _selectVehicle = selectVehicle;
        }

        [HttpGet("[action]")]
        public IActionResult GetCarList()
        {
            var CarList = _context.Cars.ToList();
            return Ok(CarList);
        }

        [HttpGet("[action]")]
        public IActionResult GetBusList()
        {
            var BussesList = _context.Busses.ToList();
            return Ok(BussesList);
        }

        [HttpGet("[action]")]
        public IActionResult GetBoatList()
        {
            var BoatsList = _context.Busses.ToList();
            return Ok(BoatsList);
        }

        [HttpPost("[action]")]
        public IActionResult ChangeCarHeadLights(int id)
        {
            var car = _context.Cars.Where(x => x.Id == id).FirstOrDefault();
            car.HeadLights = !car.HeadLights;
            _context.SaveChanges();
            return Ok(car);
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteCar(int id)
        {
            var car = _context.Cars.Where(x => x.Id == id).FirstOrDefault();
            _context.Cars.Remove(car);
            _context.SaveChanges();
            List<Car> CarList = _context.Cars.ToList();
            return Ok(CarList);
        }

        [HttpGet("[action]/{type}/{id}")]
        public IActionResult SelectVehicle(string type, int id)
        {
            var vehicle = _selectVehicle.SelectVehicle(type, id);
            return Ok(vehicle);
        }
    }
}
