using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.UI.Contract
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public Store Store { get; set; }
        public string Name { get; set; }        
        public string Image { get; set; }
        public List<Item> Items { get; set; }
        public decimal Price { get; set; }
    }
}
