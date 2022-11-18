using DotNetAssessment.Models;
using DotNetAssessment.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetAssessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimController : ControllerBase
    {
        public IClaimService claimService;

        public ClaimController(IClaimService claimService)
        {
            this.claimService = claimService;
        }

        [HttpGet(Name = "getClaims")]
        public IEnumerable<Claim> GetClaims()
        {
            return claimService.GetClaims();
        }

        [HttpGet(Name = "getClaimsByVehicle")]
        public IEnumerable<Claim> GetClaimsByVehicle(Vehicle vehicle)
        {
            return claimService.GetClaimsByVehicle(vehicle);
        }

        [HttpPost(Name = "addClaim")]
        public Claim AddClaim(Claim claim)
        {
            return claimService.AddClaim(claim);
        }

        [HttpPut(Name = "updateClaim")]
        public Claim UpdateClaim(Claim claim) 
        { 
            return claimService.UpdateClaim(claim); 
        }

        [HttpDelete(Name = "deleteClaim")]
        public void DeleteClaim(int id) 
        { 
            claimService.DeleteClaim(id); 
        }
    }
}
