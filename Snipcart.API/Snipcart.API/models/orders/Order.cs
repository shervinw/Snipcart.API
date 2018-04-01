using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Order : ResponseBase
    {
        public List<Discount> discounts { get; set; }
        public List<OrderItem> items { get; set; }
        public List<object> plans { get; set; }
        public List<Refund> refunds { get; set; }
        public List<Tax> taxes { get; set; }
        public User user { get; set; }
        public string token { get; set; }
        public bool isRecurringOrder { get; set; }
        public object parentToken { get; set; }
        public object parentInvoiceNumber { get; set; }
        public object subscriptionId { get; set; }
        public string currency { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime modificationDate { get; set; }
        public object recoveredFromCampaignId { get; set; }
        public string status { get; set; }
        public string paymentStatus { get; set; }
        public string email { get; set; }
        public bool willBePaidLater { get; set; }
        public object billingAddressFirstName { get; set; }
        public string billingAddressName { get; set; }
        public string billingAddressCompanyName { get; set; }
        public string billingAddressAddress1 { get; set; }
        public string billingAddressAddress2 { get; set; }
        public string billingAddressCity { get; set; }
        public string billingAddressCountry { get; set; }
        public string billingAddressProvince { get; set; }
        public string billingAddressPostalCode { get; set; }
        public string billingAddressPhone { get; set; }
        public BillingAddress billingAddress { get; set; }
        public object shippingAddressFirstName { get; set; }
        public string shippingAddressName { get; set; }
        public string shippingAddressCompanyName { get; set; }
        public string shippingAddressAddress1 { get; set; }
        public string shippingAddressAddress2 { get; set; }
        public string shippingAddressCity { get; set; }
        public string shippingAddressCountry { get; set; }
        public string shippingAddressProvince { get; set; }
        public string shippingAddressPostalCode { get; set; }
        public string shippingAddressPhone { get; set; }
        public ShippingAddress shippingAddress { get; set; }
        public bool shippingAddressSameAsBilling { get; set; }
        public string creditCardLast4Digits { get; set; }
        public object trackingNumber { get; set; }
        public object trackingUrl { get; set; }
        public double shippingFees { get; set; }
        public object shippingProvider { get; set; }
        public string shippingMethod { get; set; }
        public string cardHolderName { get; set; }
        public string paymentMethod { get; set; }
        public object notes { get; set; }
        public string customFieldsJson { get; set; }
        public string userId { get; set; }
        public DateTime completionDate { get; set; }
        public string cardType { get; set; }
        public string paymentGatewayUsed { get; set; }
        public string taxProvider { get; set; }
        public string lang { get; set; }
        public decimal refundsAmount { get; set; }
        public double adjustedAmount { get; set; }
        public double finalGrandTotal { get; set; }
        public int totalNumberOfItems { get; set; }
        public string invoiceNumber { get; set; }
        public bool billingAddressComplete { get; set; }
        public bool shippingAddressComplete { get; set; }
        public bool shippingMethodComplete { get; set; }
        public decimal rebateAmount { get; set; }
        public decimal subtotal { get; set; }
        public double baseTotal { get; set; }
        public decimal itemsTotal { get; set; }
        public decimal taxableTotal { get; set; }
        public double grandTotal { get; set; }
        public double total { get; set; }
        public decimal totalWeight { get; set; }
        public decimal totalRebateRate { get; set; }
        public List<CustomField> customFields { get; set; }
        public bool shippingEnabled { get; set; }
        public int numberOfItemsInOrder { get; set; }
        public string paymentTransactionId { get; set; }
        public object metadata { get; set; }
        public double taxesTotal { get; set; }
        public int itemsCount { get; set; }
        public Summary summary { get; set; }
        public string ipAddress { get; set; }
        public bool hasSubscriptions { get; set; }
    }
}
