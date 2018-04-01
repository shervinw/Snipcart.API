using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net;

namespace Snipcart
{
    public class OptionsBase
    {
        internal Dictionary<string, string> UrlValues { get; set; }

        public OptionsBase()
        {
            UrlValues = new Dictionary<string, string>();
        }

        public string GetUrlParams()
        {
            var array = UrlValues.Select(x => string.Format("{0}={1}", x.Key, x.Value));
            return "?" + string.Join("&", array);
        }
    }
}
