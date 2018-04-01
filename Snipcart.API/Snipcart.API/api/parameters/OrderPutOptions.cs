using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class OrderPutOptions
    {
        public string token { get; set; }
        public OrderStatus status { get; set; }
        public string paymentStatus { get; set; }
        public string trackingNumber { get; set; }
        public string trackingUrl { get; set; }
        public object metadata { get; set; }
    }
}
