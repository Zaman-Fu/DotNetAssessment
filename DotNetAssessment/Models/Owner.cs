using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetAssessment.Models
{

    [Table("Owners")]
    public class Owner
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }   
        
        public string DriverLicense { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
