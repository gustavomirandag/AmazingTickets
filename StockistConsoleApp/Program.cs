using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockistConsoleApp.TicketManagerService;

namespace StockistConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new TicketManagerServiceClient())
            {
                client.Open();
                client.DeleteAllTickets();
                for (int i=0; i< 200; i++)
                    client.AddTicket("RockInRio", DateTime.Now, "Recreio", 300);
                client.Close();
            }
            Console.WriteLine("Tickets Added! Click Enter to read them...");
            Console.ReadLine();

            Ticket[] tickets;

            using (var client = new TicketManagerServiceClient())
            {
                client.Open();
                tickets = client.GetAllTickets();
                client.Close();
            }

            foreach (var ticket in tickets)
                Console.WriteLine("Ticket - " + ticket.Id);

            Console.ReadLine();
        }
    }
}
