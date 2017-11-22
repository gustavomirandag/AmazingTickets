using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTicketServiceLibrary
{
    public class TicketService : ITicketService
    { 
        public Ticket GenerateTicket(string eventName, DateTime eventDateTime, string address, decimal price)
        {
            return new Ticket(eventName, eventDateTime, address, price);
        }
    }
}
