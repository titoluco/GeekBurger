using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.UI.Contract
{
    public class User
    {
        public Guid UserId { get; set; }
        public Guid RequesterId { get; set; }
        public string Face { get; set; }
    }
}
