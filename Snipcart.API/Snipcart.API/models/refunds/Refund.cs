using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Refund : ResponseBase
    {
        public string id { get; set; }
        public decimal amount { get; set; }
        public string comment { get; set; }
        public bool refundedByPaymentGateway { get; set; }
    }
}
