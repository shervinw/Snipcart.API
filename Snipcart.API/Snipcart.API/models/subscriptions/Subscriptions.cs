using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Subscriptions : ResponseBase
    {
        public string userDefinedPlanName { get; set; }
        public string userDefinedCustomerNameOrEmail { get; set; }
        public SubscriptionStatus status { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public int totalItems { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public List<Subscription> items { get; set; }
    }

    public class SubscriptionUser
    {
        public string id { get; set; }
        public string email { get; set; }
    }

    public class Schedule
    {
        public string interval { get; set; }
        public int intervalCount { get; set; }
        public int trialPeriodInDays { get; set; }
        public DateTime startsOn { get; set; }
    }

    public class Subscription : ResponseBase
    {
        public SubscriptionUser user { get; set; }
        public string initialOrderToken { get; set; }
        public object firstInvoiceReceivedOn { get; set; }
        public Schedule schedule { get; set; }
        public string itemId { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime modificationDate { get; set; }
        public object cancelledOn { get; set; }
        public decimal amount { get; set; }
        public decimal quantity { get; set; }
        public string userDefinedId { get; set; }
        public decimal totalSpent { get; set; }
        public string status { get; set; }
        public string gatewayId { get; set; }
        public object metadata { get; set; }
        public string cartId { get; set; }
        public bool recurringShipping { get; set; }
    }

    public class Invoice
    {
        public string id { get; set; }
        public string orderToken { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime modificationDate { get; set; }
        public string subscriptionId { get; set; }
        public double amount { get; set; }
        public bool paid { get; set; }
        public List<Tax> taxes { get; set; }
        public string number { get; set; }
        public double total { get; set; }
    }
}
