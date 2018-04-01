using Snipcart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class ProductPutOptions
    {
        public ProductInventoryManagementMethod invetoryManagementMethod { get; set; }
        public List<Variant> variants { get; set; }
        public int stock { get; set; }
        public bool allowOutOfStockPurchases { get; set; }
    }
}
