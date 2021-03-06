﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfTicketSeller.TicketManagerService {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TicketManagerService.ITicketManagerService")]
    public interface ITicketManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketManagerService/AddTicket", ReplyAction="http://tempuri.org/ITicketManagerService/AddTicketResponse")]
        bool AddTicket(string eventName, System.DateTime eventDateTime, string address, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketManagerService/AddTicket", ReplyAction="http://tempuri.org/ITicketManagerService/AddTicketResponse")]
        System.Threading.Tasks.Task<bool> AddTicketAsync(string eventName, System.DateTime eventDateTime, string address, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketManagerService/GetAllTickets", ReplyAction="http://tempuri.org/ITicketManagerService/GetAllTicketsResponse")]
        WcfTicketSeller.TicketManagerService.Ticket[] GetAllTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketManagerService/GetAllTickets", ReplyAction="http://tempuri.org/ITicketManagerService/GetAllTicketsResponse")]
        System.Threading.Tasks.Task<WcfTicketSeller.TicketManagerService.Ticket[]> GetAllTicketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketManagerService/UpdateToSold", ReplyAction="http://tempuri.org/ITicketManagerService/UpdateToSoldResponse")]
        bool UpdateToSold(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketManagerService/UpdateToSold", ReplyAction="http://tempuri.org/ITicketManagerService/UpdateToSoldResponse")]
        System.Threading.Tasks.Task<bool> UpdateToSoldAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketManagerService/DeleteAllTickets", ReplyAction="http://tempuri.org/ITicketManagerService/DeleteAllTicketsResponse")]
        void DeleteAllTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketManagerService/DeleteAllTickets", ReplyAction="http://tempuri.org/ITicketManagerService/DeleteAllTicketsResponse")]
        System.Threading.Tasks.Task DeleteAllTicketsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITicketManagerServiceChannel : WcfTicketSeller.TicketManagerService.ITicketManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TicketManagerServiceClient : System.ServiceModel.ClientBase<WcfTicketSeller.TicketManagerService.ITicketManagerService>, WcfTicketSeller.TicketManagerService.ITicketManagerService {
        
        public TicketManagerServiceClient() {
        }
        
        public TicketManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TicketManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddTicket(string eventName, System.DateTime eventDateTime, string address, decimal price) {
            return base.Channel.AddTicket(eventName, eventDateTime, address, price);
        }
        
        public System.Threading.Tasks.Task<bool> AddTicketAsync(string eventName, System.DateTime eventDateTime, string address, decimal price) {
            return base.Channel.AddTicketAsync(eventName, eventDateTime, address, price);
        }
        
        public WcfTicketSeller.TicketManagerService.Ticket[] GetAllTickets() {
            return base.Channel.GetAllTickets();
        }
        
        public System.Threading.Tasks.Task<WcfTicketSeller.TicketManagerService.Ticket[]> GetAllTicketsAsync() {
            return base.Channel.GetAllTicketsAsync();
        }
        
        public bool UpdateToSold(System.Guid id) {
            return base.Channel.UpdateToSold(id);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateToSoldAsync(System.Guid id) {
            return base.Channel.UpdateToSoldAsync(id);
        }
        
        public void DeleteAllTickets() {
            base.Channel.DeleteAllTickets();
        }
        
        public System.Threading.Tasks.Task DeleteAllTicketsAsync() {
            return base.Channel.DeleteAllTicketsAsync();
        }
    }
}
