using System;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITicketSellerService
    {
        [OperationContract]
        [FaultContract(typeof(EmptyQueueFaultException))]
        Ticket BuyTicket();

        [OperationContract]
        Ticket[] GetAvaiableTickets();
    }
}
