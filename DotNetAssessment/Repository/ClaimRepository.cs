using DotNetAssessment.Data;
using DotNetAssessment.Models;

namespace DotNetAssessment.Repository
{
    public class ClaimRepository : RepositoryBase<Claim>, IRepositoryBase<Claim>
    {
        public ClaimRepository(DataContext context) : base(context)
        {

        }
    }
}
