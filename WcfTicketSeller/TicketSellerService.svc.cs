using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfTicketSeller.Model.Exception;
using WcfTicketSeller.TicketManagerService;

namespace WcfTicketSeller
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession, 
        ConcurrencyMode = ConcurrencyMode.Multiple,
        IncludeExceptionDetailInFaults = true)]
    public class TicketSellerService : ITicketSellerService
    {
        private static ConcurrentQueue<Ticket> ticketsQueue = new ConcurrentQueue<Ticket>();

        public Ticket BuyTicket()
        {
            Ticket ticket;
            ticketsQueue.TryDequeue(out ticket);

            if (ticket == null && ticketsQueue.Count == 0)
                throw new FaultException<EmptyQueueException>(
                    new EmptyQueueException("Queue is empty"));

            return ticket;

            //bool result = false;
            //using (var cli = new TicketManagerServiceClient())
            //{
            //    cli.Open();
            //    result = cli.UpdateToSold(ticket.Id);
            //    cli.Close();
            //}
            //return result;
        }

        public Ticket[] GetAvaiableTickets()
        {
            Ticket[] tickets;
            using (var cli = new TicketManagerServiceClient())
            {
                cli.Open();
                tickets = cli.GetAllTickets()?.Where(t => t.AvaiableToSell)?.ToArray();
                cli.Close();
            }

            foreach (var ticket in tickets)
            {
                ticketsQueue.Enqueue(ticket);
            }

            return tickets;
        }
    }
}
