using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class OrderNotificationPostOptions
    {
        public string message { get; set; }
        public NotificationType type { get; set; }
        public DeliveryMethod deliveryMethod { get; set; }
    }
}
