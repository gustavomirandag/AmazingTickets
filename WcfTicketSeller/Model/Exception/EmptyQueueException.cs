using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfTicketSeller.Model.Exception
{
    [DataContract]
    public class EmptyQueueException
    {
        [DataMember]
        public string Message { get; set; }
        public EmptyQueueException(string message)
        {
            Message = message;
        }
    }
}