using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetAssessment.Models
{
    [Table("Claims")]
    public class Claim
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateOnly Date { get; set; }



    }
}
