using System;
using System.ComponentModel.DataAnnotations;
namespace DealerOnShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}

        [Required(ErrorMessage="Product Name is required")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}