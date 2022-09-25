using System;
using System.Collections.Generic;

namespace Api.Entities
{
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public short ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
