using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NightlifeEntertainment
{
    public class VipTicket : Ticket
    {
        public VipTicket(IPerformance performance)
            : base(performance, TicketType.VIP)
        {
        }
    }
}
