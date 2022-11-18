using DotNetAssessment.Data;
using DotNetAssessment.Models;

namespace DotNetAssessment.Services
{
    public class ClaimService : IClaimService
    {
        public DataContext context;

        public ClaimService(DataContext context)
        {
            this.context = context;
        }

        public Claim AddClaim(Claim claim)
        {
            context.Add(claim);
            context.SaveChanges();
            return claim;
        }

        public void DeleteClaim(int id)
        {
            Claim claimDelete = context.Claims.FirstOrDefault(o => o.Id == id);
            context.Claims.Remove(claimDelete);
            context.SaveChanges();
        }

        public IEnumerable<Claim> GetClaims()
        {
            return context.Claims.ToList();
        }

        public Claim UpdateClaim(Claim claim)
        {
            context.Update(claim);
            context.SaveChanges();
            return claim;
        }
        
        public IEnumerable<Claim> GetClaimsByVehicle(Vehicle vehicle)
        {
            return context.Claims.Where(o => o.VehicleId == vehicle.Id).ToList();
        }
    }
}
