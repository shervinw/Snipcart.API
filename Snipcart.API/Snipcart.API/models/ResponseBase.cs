using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Snipcart.Models
{
    public class ResponseBase : IResponseBase
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
