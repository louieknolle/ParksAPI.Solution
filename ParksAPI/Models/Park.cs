using System.ComponentModel.DataAnnotations;

namespace ParksAPI.Models
{
    public class Park
    {
        public int ParkId { get; set; }

        [Required]
        [StringLength(50)]
        public string ParkName { get; set; }

        [Required]
        [StringLength(20)]
        public string TypeOfPark { get; set; }

        [Required]
        [StringLength(40)]
        public string Location { get; set; }
    }
}