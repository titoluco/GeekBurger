using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.UI.Contract
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Store Store { get; set; }
        public decimal Total { get; set; }
        public List<Product> Products { get; set; }
    }
}
