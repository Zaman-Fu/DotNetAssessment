using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetAssessment.Models
{

    [Table("Vehicles")]
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }

        public string Vin { get; set; }

        public string Color { get; set; }

        public string Year { get; set; }

        public ICollection<Claim> Claims { get; set; }
    }
}
