using DotNetAssessment.Data;
using DotNetAssessment.Models;

namespace DotNetAssessment.Services
{
    public class OwnerService : IOwnerService
    {
        public DataContext context;

        public OwnerService(DataContext context)
        {
            this.context = context;
        }

        public Owner AddOwner(Owner owner)
        {
            context.Add(owner);
            context.SaveChanges();
            return owner;
        }

        public IEnumerable<Owner> GetOwners()
        {
            return context.Owners.ToList();
        }

        public Owner UpdateOwner(Owner owner)
        {
            context.Update(owner);
            context.SaveChanges();
            return owner;
        }

        public void DeleteOwner(int id)
        {
            Owner ownerDelete = context.Owners.FirstOrDefault(o => o.Id == id);
            context.Owners.Remove(ownerDelete);
            context.SaveChanges();
        }
    }
}
