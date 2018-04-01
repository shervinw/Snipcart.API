using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Customers : ResponseBase
    {
        public int totalItems { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public List<User> items { get; set; }
    }
}
