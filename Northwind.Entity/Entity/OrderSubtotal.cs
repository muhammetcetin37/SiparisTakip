using System;
using System.Collections.Generic;

namespace Northwind.Entity.Entity
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
