using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Summary
    {
        public decimal subtotal { get; set; }
        public decimal taxableTotal { get; set; }
        public double total { get; set; }
        public double payableNow { get; set; }
        public string paymentMethod { get; set; }
        public List<Tax> taxes { get; set; }
        public double adjustedTotal { get; set; }
        public object shipping { get; set; }
    }
}
