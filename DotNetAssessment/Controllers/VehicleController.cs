using DotNetAssessment.Models;
using DotNetAssessment.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAssessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        public IVehicleService vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;
        }

        [HttpGet(Name = "getVehicles")]
        public IEnumerable<Vehicle> GetVehicles() { return vehicleService.GetVehicles(); }

        [HttpGet(Name = "getVehiclesByOwner")]
        public IEnumerable<Vehicle> GetVehiclesByOwner(Owner owner) 
        {
            return vehicleService.GetVehicleByOwner(owner);
        }

        [HttpPost(Name = "addVehicle")]
        public Vehicle AddVehicle(Vehicle vehicle)
        {
            return vehicleService.AddVehicle(vehicle);
        }

        [HttpPut(Name = "updateVehicle")]
        public Vehicle UpdateVehicle(Vehicle vehicle) { return vehicleService.UpdateVehicle(vehicle); }

        [HttpDelete(Name = "deleteVehicle")]
        public void DeleteVehicle(int id) { vehicleService.DeleteVehicle(id); }

    }
}
