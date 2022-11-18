using DotNetAssessment.Data;
using DotNetAssessment.Models;

namespace DotNetAssessment.Repository
{
    public class VehiclesRepository : RepositoryBase<Vehicle>,IRepositoryBase<Vehicle>
    {

        public VehiclesRepository(DataContext context) : base(context)
        {
           
        }
    }
}
