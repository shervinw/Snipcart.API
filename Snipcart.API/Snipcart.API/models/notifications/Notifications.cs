using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Notifications : ResponseBase
    {
        public int totalItems { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public List<Notification> items { get; set; }
    }

    public class Notification
    {
        public string id { get; set; }
        public DateTime creationDate { get; set; }
        public NotificationType type { get; set; }
        public string deliveryMethod { get; set; }
        public string body { get; set; }
        public string message { get; set; }
        public string subject { get; set; }
        public DateTime? sentOn { get; set; }
    } 
}
