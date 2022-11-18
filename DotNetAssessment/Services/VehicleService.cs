using DotNetAssessment.Data;
using DotNetAssessment.Models;

namespace DotNetAssessment.Services
{
    public class VehicleService : IVehicleService
    {
        public DataContext context;

        public VehicleService(DataContext context)
        {
            this.context = context;
        }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            context.Add(vehicle);
            context.SaveChanges();
            return vehicle;
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return context.Vehicles.ToList();
        }

        public Vehicle UpdateVehicle(Vehicle vehicle)
        {
            context.Update(vehicle);
            context.SaveChanges();
            return vehicle;
        }

        public void DeleteVehicle(int id)
        {
            Vehicle vehicleDelete = context.Vehicles.FirstOrDefault(o => o.Id == id);
            context.Vehicles.Remove(vehicleDelete);
            context.SaveChanges();
        }

    }
}
