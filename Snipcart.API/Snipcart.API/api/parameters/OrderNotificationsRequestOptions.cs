using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart
{
    public class OrderNotificationsRequestOptions : OptionsBase
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

    }
}
