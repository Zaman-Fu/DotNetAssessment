using DotNetAssessment.Models;

namespace DotNetAssessment.Services
{
    public interface IClaimService
    {
        Claim AddClaim(Claim owner);

        IEnumerable<Claim> GetClaims();
        Claim UpdateClaim(Claim owner);
        void DeleteClaim(int id);

        IEnumerable<Claim> GetClaimsByVehicle(Vehicle vehicle);
    }
}
