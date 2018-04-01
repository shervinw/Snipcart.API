using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Tax
    {
        public string taxName { get; set; }
        public double taxRate { get; set; }
        public double amount { get; set; }
        public string numberForInvoice { get; set; }
        public bool includedInPrice { get; set; }
        public bool appliesOnShipping { get; set; }
    }
}
