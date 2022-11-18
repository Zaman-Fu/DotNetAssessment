using DotNetAssessment.Data;
using DotNetAssessment.Model;

namespace DotNetAssessment.Repository
{
    public class Vehicles : IRepository<Vehicles>
    {
        private readonly DataContext _context;

        public Vehicles(DataContext context)
        {
            _context = context;
        }

        public bool AddItem(Vehicles vehicle)
        {
            _context.Add(vehicle);
            return Save();
        }

        public bool DeleteItem(Vehicles vehicle)
        {
            _context.Remove(vehicle);
            return Save();
        }

        public ICollection<Vehicles> GetAll()
        {
            return _context.Vehicles.ToList();
        }

        public bool ModifyItem(Vehicles vehicle)
        {
            _context.Update(vehicle);
            return Save(); 
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
