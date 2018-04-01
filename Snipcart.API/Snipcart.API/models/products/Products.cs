using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class Products : ResponseBase
    {
        public int totalItems { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public List<Product> items { get; set; }
    }

    public class Product : ResponseBase
    {
        public string mode { get; set; }
        public string userDefinedId { get; set; }
        public string url { get; set; }
        public decimal price { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public bool archived { get; set; }
        public ProductStatistics statistics { get; set; }
        public List<CustomField> customFields { get; set; }
        public object metadata { get; set; }
        public string id { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime modificationDate { get; set; }
        public string inventoryManagementMethod { get; set; }
        public int? stock { get; set; }
        public int? totalStock { get; set; }
        public bool? allowOutOfStockPurchases { get; set; }
        public List<Variant> variants { get; set; }
    }

    public class ProductStatistics
    {
        public int numberOfSales { get; set; }
        public double totalSales { get; set; }
    }

    public class Variation
    {
        public string name { get; set; }
        public string option { get; set; }
    }

    public class Variant
    {
        public int stock { get; set; }
        public List<Variation> variation { get; set; }
        public bool allowOutOfStockPurchases { get; set; }
    }

    public class CustomField
    {
        public string name { get; set; }
        public string operation { get; set; }
        public string type { get; set; }
        public string options { get; set; }
        public bool? required { get; set; }
        public string value { get; set; }
        public List<string> optionsArray { get; set; }
    }

    public class Dimensions
    {
        public object width { get; set; }
        public object height { get; set; }
        public object length { get; set; }
        public int weight { get; set; }
    }
}
