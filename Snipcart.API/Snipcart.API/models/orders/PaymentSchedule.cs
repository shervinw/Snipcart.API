using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcart.Models
{
    public class PaymentSchedule
    {
        public int interval { get; set; }
        public int intervalCount { get; set; }
        public object trialPeriodInDays { get; set; }
        public DateTime startsOn { get; set; }
    }
}
