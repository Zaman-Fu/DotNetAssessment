using DotNetAssessment.Data;
using DotNetAssessment.Model;

namespace DotNetAssessment.Repository
{
    public class OwnersRepository : IRepository<Owners>
    {
        private readonly DataContext _context;

        public OwnersRepository(DataContext context)
        {
            _context = context;
        }

        public bool AddItem(Owners owner)
        {
            _context.Add(owner);
            return Save();
        }

        public ICollection<Owners> GetAll()
        {
            return _context.Owners.ToList();
        }

        public bool ModifyItem(Owners owner)
        {
            _context.Update(owner);
            return Save();
        }

        public bool DeleteItem(Owners owner)
        {
            _context.Remove(owner);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }



    }
}
