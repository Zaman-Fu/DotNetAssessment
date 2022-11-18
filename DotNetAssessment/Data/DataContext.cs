using DotNetAssessment.Model;
using Microsoft.EntityFrameworkCore;

namespace DotNetAssessment.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public ICollection<Owners> Owners { get; internal set; }
    }
}
