using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class CustomersRequestOptions : OptionsBase
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
        public CustomerStatus status
        {
            set
            {
                UrlValues["status"] = value.ToString();
            }
        }
        public string email
        {
            set
            {
                UrlValues["email"] = value.ToString();
            }
        }
        public string name
        {
            set
            {
                UrlValues["name"] = value.ToString();
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
