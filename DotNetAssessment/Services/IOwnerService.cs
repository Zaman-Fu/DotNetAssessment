using DotNetAssessment.Models;

namespace DotNetAssessment.Services
{
    public interface IOwnerService
    {
        Owner AddOwner(Owner owner);

        IEnumerable<Owner> GetOwners();
        Owner UpdateOwner(Owner owner);
        void DeleteOwner(int id);

    }
}
