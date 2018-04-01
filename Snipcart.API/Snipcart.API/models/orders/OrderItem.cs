using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class OrderItem
    {
        public PaymentSchedule paymentSchedule { get; set; }
        public string token { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
        public object fileGuid { get; set; }
        public string url { get; set; }
        public string id { get; set; }
        public string initialData { get; set; }
        public string description { get; set; }
        public List<object> categories { get; set; }
        public decimal weight { get; set; }
        public string image { get; set; }
        public object originalPrice { get; set; }
        public string uniqueId { get; set; }
        public bool stackable { get; set; }
        public object minQuantity { get; set; }
        public object maxQuantity { get; set; }
        public DateTime addedOn { get; set; }
        public DateTime modificationDate { get; set; }
        public bool shippable { get; set; }
        public bool taxable { get; set; }
        public bool duplicatable { get; set; }
        public object width { get; set; }
        public object height { get; set; }
        public object length { get; set; }
        public object metadata { get; set; }
        public decimal totalPrice { get; set; }
        public decimal totalWeight { get; set; }
        public List<object> taxes { get; set; }
        public AlternatePrices alternatePrices { get; set; }
        public List<object> customFields { get; set; }
        public decimal unitPrice { get; set; }
        public bool hasDimensions { get; set; }
    }
}
