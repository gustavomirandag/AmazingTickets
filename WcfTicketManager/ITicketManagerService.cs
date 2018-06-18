using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfTicketManager.TicketService;

namespace WcfTicketManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITicketManagerService
    {
        [OperationContract]
        bool AddTicket(string eventName, 
            DateTime eventDateTime, 
            string address, decimal price);

        [OperationContract]
        Ticket[] GetAllTickets();

        [OperationContract]
        bool UpdateToSold(Guid id);

        [OperationContract]
        void DeleteAllTickets();
    }
}
