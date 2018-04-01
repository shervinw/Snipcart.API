using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class AbandonedCartsRequestOptions : OptionsBase
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

        public TimeRange timeRange
        {
            set
            {
                UrlValues["timeRange"] = value.ToString();
            }
        }
        public string minimalValue
        {
            set
            {
                UrlValues["minimalValue"] = value.ToString();
            }
        }
        public string email
        {
            set
            {
                UrlValues["email"] = value.ToString();
            }

        }
        public string productId
        {
            set
            {
                UrlValues["productId"] = value.ToString();
            }

        }
    }
}
