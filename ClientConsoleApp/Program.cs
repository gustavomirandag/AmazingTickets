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
            Ticket ticket  = null;
            using (var cli = new TicketSellerServiceClient())
            {
                cli.Open();
                do
                {
                    try
                    {
                        ticket = cli.BuyTicket();
                    }
                    catch(FaultException<TicketSellerService.EmptyQueueFaultException> ex)
                    {
                        Console.WriteLine("FaultException in thread 1:");
                        Console.WriteLine($" - Result: {ex.Detail.Result}");
                        Console.WriteLine($" - Message: {ex.Detail.Message}");
                        Console.WriteLine($" - Description: {ex.Detail.Description}");
                        break;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    if (ticket != null)
                        countTicketsByClient1++;
                } while (ticket != null);
                cli.Close();
            }

        }
        private static void ExecuteAsClient2()
        {
            Ticket ticket = null;
            using (var cli = new TicketSellerServiceClient())
            {
                cli.Open();
                do
                {
                    try
                    {
                        ticket = cli.BuyTicket();
                    }
                    catch (FaultException<EmptyQueueFaultException> ex)
                    {
                        Console.WriteLine("FaultException in thread 2:");
                        Console.WriteLine($" - Result: {ex.Detail.Result}");
                        Console.WriteLine($" - Message: {ex.Detail.Message}");
                        Console.WriteLine($" - Description: {ex.Detail.Description}");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    if (ticket != null)
                        countTicketsByClient2++;
                } while (ticket != null);
                cli.Close();
            }
        }
    }
}
