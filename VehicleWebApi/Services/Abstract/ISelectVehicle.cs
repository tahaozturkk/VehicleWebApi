using VehicleWebApi.Models.Abstract;

namespace VehicleWebApi.Services.Abstract
{
    public interface ISelectVehicle
    {
        Vehicle SelectVehicle(string type, int id);
    }
}
