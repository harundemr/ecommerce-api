using System;
using System.Collections.Generic;

#nullable disable

namespace eCommerceApi.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }
        public decimal Price { get; set; }
        public string Note { get; set; }
        public DateTime? Date { get; set; }
    }
}
