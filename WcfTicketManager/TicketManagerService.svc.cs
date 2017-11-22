using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfTicketManager.TicketService;

namespace WcfTicketManager
{
    public class TicketServiceManager : ITicketManagerService
    {
        private static ConcurrentDictionary<Guid,Ticket> tickets = new ConcurrentDictionary<Guid,Ticket>();

        public bool AddTicket(string eventName, DateTime eventDateTime, string address, decimal price)
        {
            Ticket ticket;

            using (var cli = new TicketServiceClient())
            {
                cli.Open();
                ticket = cli.GenerateTicket(eventName, eventDateTime, address, price);
                cli.Close();
            }

            if (ticket != null)
                return tickets.TryAdd(ticket.Id,ticket);

            return false;
        }

        public Ticket[] GetAllTickets()
        {
            return tickets.Values.ToArray<Ticket>();
        }

        public bool UpdateToSold(Guid id)
        {
            Ticket ticket;
            ticket = tickets[id];
            ticket.AvaiableToSell = false;

            if (ticket != null)
                return tickets.TryUpdate(id, ticket, ticket);

            return false;
        }
    }
}
