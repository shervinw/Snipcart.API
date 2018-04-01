using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class BillingAddress
    {
        public string fullName { get; set; }
        public object firstName { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string fullAddress { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string province { get; set; }
        public string phone { get; set; }
        public object vatNumber { get; set; }
    }
}
