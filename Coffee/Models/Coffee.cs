using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Coffees
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        public int BeanVarietyId { get; set; }
       
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public BeanVariety BeanVariety { get; set; }
    }
}