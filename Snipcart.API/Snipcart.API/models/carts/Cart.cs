using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class AbandonedCarts : ResponseBase
    {
        public object minimalValue { get; set; }
        public string timeRange { get; set; }
        public object email { get; set; }
        public object productId { get; set; }
        public int totalItems { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public List<AbandonedCart> items { get; set; }
    }

    public class ShippingInformation
    {
        public object provider { get; set; }
        public int fees { get; set; }
        public string method { get; set; }
    }

    public class AbandonedCart : ResponseBase
    {
        public string token { get; set; }
        public string email { get; set; }
        public string mode { get; set; }
        public string status { get; set; }
        public bool shipToBillingAddress { get; set; }
        public BillingAddress billingAddress { get; set; }
        public DateTime modificationDate { get; set; }
        public ShippingAddress shippingAddress { get; set; }
        public object completionDate { get; set; }
        public string invoiceNumber { get; set; }
        public ShippingInformation shippingInformation { get; set; }
        public int paymentMethod { get; set; }
        public Summary summary { get; set; }
        public object metadata { get; set; }
        public List<OrderItem> items { get; set; }
        public List<Discount> discounts { get; set; }
        public List<CustomField> customFields { get; set; }
        public List<object> plans { get; set; }
        public List<Refund> refunds { get; set; }
        public string currency { get; set; }
        public int totalWeight { get; set; }
        public int total { get; set; }
    }
}
