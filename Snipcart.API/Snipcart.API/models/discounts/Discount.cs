using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Discount : ResponseBase
    {
        public string id { get; set; }
        public string name { get; set; }
        public DiscountTrigger trigger { get; set; }
        public string code { get; set; }
        public string itemId { get; set; }
        public decimal totalToReach { get; set; }
        public DiscountType type { get; set; }
        public decimal rate { get; set; }
        public decimal amount { get; set; }
        public string alternatePrice { get; set; }
        public int maxNumberOfUsages { get; set; }
        public DateTime expires { get; set; }
        public int numberOfUsages { get; set; }
        public int numberOfUsagesUncompleted { get; set; }
        public string shippingDescription { get; set; }
        public decimal shippingCost { get; set; }
        public int shippingGuaranteedDaysToDelivery { get; set; }
    }
}
