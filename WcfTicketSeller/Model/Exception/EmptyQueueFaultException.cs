using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfTicketSeller.Model.Exception
{
    [DataContract]
    public class EmptyQueueFaultException
    {
        [DataMember]
        public bool Result { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Description { get; set; }

        public EmptyQueueFaultException(bool result, string message, string description)
        {
            Result = result;
            Message = message;
            Description = description;
        }
    }
}