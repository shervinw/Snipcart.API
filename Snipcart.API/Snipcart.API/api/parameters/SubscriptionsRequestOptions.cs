using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class SubscriptionsRequestOptions : OptionsBase
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
        public SubscriptionStatus status
        {
            set
            {
                UrlValues["status"] = value.ToString();
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
        public string userDefinedPlanName
        {
            set
            {
                UrlValues["userDefinedPlanName"] = value.ToString();
            }
        }
        public string userDefinedCustomerNameOrEmail
        {
            set
            {
                UrlValues["userDefinedCustomerNameOrEmail"] = value.ToString();
            }
        }
    }
}
