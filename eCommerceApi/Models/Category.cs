using System;
using System.Collections.Generic;

#nullable disable

namespace eCommerceApi.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RefId { get; set; }
    }
}
