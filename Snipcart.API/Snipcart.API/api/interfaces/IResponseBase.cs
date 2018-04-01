using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Snipcart
{
    public interface IResponseBase
    {
        string message { get; set; }
        IErrors errors { get; set; }
        HttpStatusCode statuscode { get; set; }
    }
    public interface IErrors
    {
        List<string> parameter { get; set; }
    }
}
