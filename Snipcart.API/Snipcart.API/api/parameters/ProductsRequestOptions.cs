using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class ProductsRequestOptions : OptionsBase
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
        public string userDefinedId
        {
            set
            {
                UrlValues["userDefinedId"] = value.ToString();
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
