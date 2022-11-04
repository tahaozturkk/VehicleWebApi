using VehicleWebApi.Models.Abstract;
using VehicleWebApi.Models.Context;
using VehicleWebApi.Services.Abstract;

namespace VehicleWebApi.Services.Concrete
{
    public class SelectVehicle : ISelectVehicle
    {
        readonly DatabaseContext _context;

        public SelectVehicle(DatabaseContext context)
        {
            _context = context;
        }

        Vehicle ISelectVehicle.SelectVehicle(string type, int id)
        {
            if (type.ToLower() == "car")
            {
                return _context.Cars.Where(x => x.Id == id).FirstOrDefault();
            }
            if (type.ToLower() == "boat")
            {
                return _context.Boats.Where(x => x.Id == id).FirstOrDefault();
            }
            if (type.ToLower() == "bus")
            {
                return _context.Busses.Where(x => x.Id == id).FirstOrDefault();
            }
            return null;
        }
    }
}
