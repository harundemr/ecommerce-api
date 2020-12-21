using System;
using System.Collections.Generic;

#nullable disable

namespace eCommerceApi.Models
{
    public partial class AdminUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
    }
}
