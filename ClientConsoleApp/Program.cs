using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConsoleApp.TicketSellerService;
using System.Collections.Concurrent;
using System.Threading;
using System.ServiceModel;

namespace ClientConsoleApp
{
    class Program
    {

        private static int countTicketsByClient1 = 0;
        private static int countTicketsByClient2 = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to start consuming tickets...");
            Console.ReadLine();


            Ticket[] tickets;

            using (var cli = new TicketSellerServiceClient())
            {
                cli.Open();
                tickets = cli.GetAvaiableTickets();
                cli.Close();
            }

            Thread client1 = new Thread(ExecuteAsClient);
            client1.Start();
            Thread client2 = new Thread(ExecuteAsClient2);
            client2.Start();

            while (client1.IsAlive || client2.IsAlive)
            {
                //Do something
            }

            Console.WriteLine($"Quantity of tickets consumed by the first thread = {countTicketsByClient1}");
            Console.WriteLine($"Quantity of tickets consumed by the second thread = {countTicketsByClient2}");

            Console.ReadLine();

        }

        private static void ExecuteAsClient()
        {
            Ticket ticket;
            using (var cli = new TicketSellerServiceClient())
            {
                cli.Open();
                do
                {
                    try
                    {
                        ticket = cli.BuyTicket();
                    }
                    catch(FaultException<EmptyQueueException> ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                    if (ticket != null)
                        countTicketsByClient1++;
                } while (ticket != null);
                cli.Close();
            }

        }
        private static void ExecuteAsClient2()
        {
            Ticket ticket;
            using (var cli = new TicketSellerServiceClient())
            {
                cli.Open();
                do
                {
                    try
                    {
                        ticket = cli.BuyTicket();
                    }
                    catch (FaultException<EmptyQueueException> ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                    if (ticket != null)
                        countTicketsByClient2++;
                } while (ticket != null);
                cli.Close();
            }
        }
    }
}
