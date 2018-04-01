using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Orders : ResponseBase
    {
        public OrderStatus status { get; set; }
        public List<Order> items { get; set; }
    }
}
