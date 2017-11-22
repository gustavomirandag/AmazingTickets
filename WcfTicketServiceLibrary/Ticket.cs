using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Runtime.Serialization;

namespace WcfTicketServiceLibrary
{
    [DataContract]
    public class Ticket
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Event { get; set; }
        [DataMember]
        public DateTime EventDateTime { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public Decimal Price { get; set; }
        [DataMember]
        public bool AvaiableToSell { get; set; }

        public Ticket(string @event, DateTime eventDateTime, string address, decimal price)
        {
            Id = Guid.NewGuid();
            Event = @event;
            EventDateTime = eventDateTime;
            Address = address;
            Price = price;
            AvaiableToSell = true;
        }
    }
}
