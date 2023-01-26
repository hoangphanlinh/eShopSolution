using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid UserID { get; set; }
        public Product Product { get; set; }
        public DateTime DateCreated { get; set; }
        public AppUser AppUser { get; set; }
    }
}
