using DotNetAssessment.Models;

namespace DotNetAssessment.Services
{
    public interface IVehicleService
    {
        Vehicle AddVehicle(Vehicle owner);

        IEnumerable<Vehicle> GetVehicles();
        Vehicle UpdateVehicle(Vehicle owner);
        void DeleteVehicle(int id);
        IEnumerable<Vehicle> GetVehicleByOwner(Owner owner);
    }
}
