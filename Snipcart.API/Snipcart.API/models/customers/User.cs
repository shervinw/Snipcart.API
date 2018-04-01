using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class User : ResponseBase
    {
        public string id { get; set; }
        public string email { get; set; }
        public Statistics statistics { get; set; }
        public DateTime creationDate { get; set; }
        public string mode { get; set; }
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
        public bool shippingAddressSameAsBilling { get; set; }
        public CustomerStatus status { get; set; }
        public object sessionToken { get; set; }
        public string gravatarUrl { get; set; }
        public BillingAddress billingAddress { get; set; }
        public ShippingAddress shippingAddress { get; set; }
    }
}
