using System;
using System.Collections.Generic;
using System.Net;

namespace Snipcart
{
    public class SnipcartList<T> : List<T>, IResponseBase
    {
        public string message { get; set; }
        public IErrors errors { get; set; }
        public HttpStatusCode statuscode { get; set; }
        public bool IsSuccessStatusCode
        {
            get { return ((int)statuscode >= 200) && ((int)statuscode <= 299); }
        }
    }
}
