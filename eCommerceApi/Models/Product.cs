using System;
using System.Collections.Generic;

#nullable disable

namespace eCommerceApi.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public bool IsStock { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public string Unit { get; set; }
    }
}
