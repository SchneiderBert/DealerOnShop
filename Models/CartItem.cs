using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DealerOnShop.Models
{
    public class CartItem
    {
        [Key]
        public int ItemId {get;set;}
        public int Quantity { get; set; }
        public int ProductId {get;set;}
        public Product product {get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}