﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServices1.Test.SampleServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SampleData", Namespace="http://schemas.datacontract.org/2004/07/WcfService1.Business")]
    [System.SerializableAttribute()]
    public partial class SampleData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ClearedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsClearedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PostingDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public double Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((this.ApplicationIdField.Equals(value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ClearedDate {
            get {
                return this.ClearedDateField;
            }
            set {
                if ((this.ClearedDateField.Equals(value) != true)) {
                    this.ClearedDateField = value;
                    this.RaisePropertyChanged("ClearedDate");
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
        public bool IsCleared {
            get {
                return this.IsClearedField;
            }
            set {
                if ((this.IsClearedField.Equals(value) != true)) {
                    this.IsClearedField = value;
                    this.RaisePropertyChanged("IsCleared");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PostingDate {
            get {
                return this.PostingDateField;
            }
            set {
                if ((this.PostingDateField.Equals(value) != true)) {
                    this.PostingDateField = value;
                    this.RaisePropertyChanged("PostingDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SampleServices.ISampleDataService")]
    public interface ISampleDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleDataService/GetData", ReplyAction="http://tempuri.org/ISampleDataService/GetDataResponse")]
        WcfServices1.Test.SampleServices.SampleData[] GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleDataService/GetData", ReplyAction="http://tempuri.org/ISampleDataService/GetDataResponse")]
        System.Threading.Tasks.Task<WcfServices1.Test.SampleServices.SampleData[]> GetDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISampleDataServiceChannel : WcfServices1.Test.SampleServices.ISampleDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleDataServiceClient : System.ServiceModel.ClientBase<WcfServices1.Test.SampleServices.ISampleDataService>, WcfServices1.Test.SampleServices.ISampleDataService {
        
        public SampleDataServiceClient() {
        }
        
        public SampleDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfServices1.Test.SampleServices.SampleData[] GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<WcfServices1.Test.SampleServices.SampleData[]> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
    }
}
