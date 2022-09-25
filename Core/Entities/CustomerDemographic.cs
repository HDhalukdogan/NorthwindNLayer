using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class CustomerDemographic
    {
        public CustomerDemographic()
        {
            Customers = new HashSet<Customer>();
        }

        public char CustomerTypeId { get; set; }
        public string? CustomerDesc { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
