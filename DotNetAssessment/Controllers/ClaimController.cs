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

        [HttpGet("getClaimsByVehicle")]
        public IEnumerable<Claim> GetClaimsByVehicle(int vehicleId)
        {
            return claimService.GetClaimsByVehicle(vehicleId);
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
