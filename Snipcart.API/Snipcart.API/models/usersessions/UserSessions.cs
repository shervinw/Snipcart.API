using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class UserSessions : ResponseBase
    {
        public string token { get; set; }
        public DateTime expires { get; set; }
        public List<User> customer { get; set; }
    }
}
