﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfTicketManager.TicketService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ticket", Namespace="http://schemas.datacontract.org/2004/07/WcfTicketServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Ticket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AvaiableToSellField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EventField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EventDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AvaiableToSell {
            get {
                return this.AvaiableToSellField;
            }
            set {
                if ((this.AvaiableToSellField.Equals(value) != true)) {
                    this.AvaiableToSellField = value;
                    this.RaisePropertyChanged("AvaiableToSell");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event {
            get {
                return this.EventField;
            }
            set {
                if ((object.ReferenceEquals(this.EventField, value) != true)) {
                    this.EventField = value;
                    this.RaisePropertyChanged("Event");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EventDateTime {
            get {
                return this.EventDateTimeField;
            }
            set {
                if ((this.EventDateTimeField.Equals(value) != true)) {
                    this.EventDateTimeField = value;
                    this.RaisePropertyChanged("EventDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TicketService.ITicketService")]
    public interface ITicketService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/GenerateTicket", ReplyAction="http://tempuri.org/ITicketService/GenerateTicketResponse")]
        WcfTicketManager.TicketService.Ticket GenerateTicket(string eventName, System.DateTime eventDateTime, string address, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/GenerateTicket", ReplyAction="http://tempuri.org/ITicketService/GenerateTicketResponse")]
        System.Threading.Tasks.Task<WcfTicketManager.TicketService.Ticket> GenerateTicketAsync(string eventName, System.DateTime eventDateTime, string address, decimal price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITicketServiceChannel : WcfTicketManager.TicketService.ITicketService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TicketServiceClient : System.ServiceModel.ClientBase<WcfTicketManager.TicketService.ITicketService>, WcfTicketManager.TicketService.ITicketService {
        
        public TicketServiceClient() {
        }
        
        public TicketServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TicketServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfTicketManager.TicketService.Ticket GenerateTicket(string eventName, System.DateTime eventDateTime, string address, decimal price) {
            return base.Channel.GenerateTicket(eventName, eventDateTime, address, price);
        }
        
        public System.Threading.Tasks.Task<WcfTicketManager.TicketService.Ticket> GenerateTicketAsync(string eventName, System.DateTime eventDateTime, string address, decimal price) {
            return base.Channel.GenerateTicketAsync(eventName, eventDateTime, address, price);
        }
    }
}
