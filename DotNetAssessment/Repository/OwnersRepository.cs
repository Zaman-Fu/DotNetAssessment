using DotNetAssessment.Data;
using DotNetAssessment.Models;

namespace DotNetAssessment.Repository
{
    public class OwnersRepository : RepositoryBase<Owner>,IRepositoryBase<Owner>
    {

        public OwnersRepository(DataContext context) : base(context)
        {
           
        }

        
    }
}
