using System.ComponentModel.DataAnnotations;

namespace Project_Api.Models.Entities
{
    public class Addproductdto
    {
        [Required]
        public string ItemName { get; set; }

        public decimal Price { get; set; }

        public int ItemCount { get; set; }

        public string category { get; set; }
    }
}
