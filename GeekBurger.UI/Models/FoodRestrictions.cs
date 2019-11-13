using System;
using System.Collections.Generic;
using System.Text;
using GeekBurger.UI.Contract;

namespace GeekBurger.UI.Models
{
    public class FoodRestrictions
    {
        public Restriction Restrictions { get; set; }
        public User User { get; set; }
    }
}
