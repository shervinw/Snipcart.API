using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class OrdersRequestOptions : OptionsBase
    {
        public int offset
        {
            set
            {
                UrlValues["offset"] = value.ToString();
            }
        }
        public int limit
        {
            set
            {
                UrlValues["limit"] = value.ToString();
            }
        }
        public OrderStatus status
        {
            set
            {
                UrlValues["status"] = value.ToString();
            }
        }
        public string invoiceNumber
        {
            set
            {
                UrlValues["invoiceNumber"] = value.ToString();
            }
        }
        public string placedBy
        {
            set
            {
                UrlValues["placedBy"] = value.ToString();
            }
        }
        public DateTime from
        {
            set
            {
                UrlValues["from"] = value.ToString();
            }
        }
        public DateTime to
        {
            set
            {
                UrlValues["to"] = value.ToString();
            }
        }
    }
}
