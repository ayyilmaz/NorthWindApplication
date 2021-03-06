﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCandWCFAssignment.ProductsService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/DataServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float DiscountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> RequiredDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;
        
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
        public string CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerIDField, value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Discount {
            get {
                return this.DiscountField;
            }
            set {
                if ((this.DiscountField.Equals(value) != true)) {
                    this.DiscountField = value;
                    this.RaisePropertyChanged("Discount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> RequiredDate {
            get {
                return this.RequiredDateField;
            }
            set {
                if ((this.RequiredDateField.Equals(value) != true)) {
                    this.RequiredDateField = value;
                    this.RaisePropertyChanged("RequiredDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceExecptions", Namespace="http://schemas.datacontract.org/2004/07/DataServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class ServiceExecptions : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
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
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductsService.IProductsService")]
    public interface IProductsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetCategories", ReplyAction="http://tempuri.org/IProductsService/GetCategoriesResponse")]
        string GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetCategories", ReplyAction="http://tempuri.org/IProductsService/GetCategoriesResponse")]
        System.Threading.Tasks.Task<string> GetCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProductsByID", ReplyAction="http://tempuri.org/IProductsService/GetProductsByIDResponse")]
        string GetProductsByID(int categoryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetProductsByID", ReplyAction="http://tempuri.org/IProductsService/GetProductsByIDResponse")]
        System.Threading.Tasks.Task<string> GetProductsByIDAsync(int categoryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/SaveOrder", ReplyAction="http://tempuri.org/IProductsService/SaveOrderResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MVCandWCFAssignment.ProductsService.ServiceExecptions), Action="http://tempuri.org/IProductsService/SaveOrderServiceExecptionsFault", Name="ServiceExecptions", Namespace="http://schemas.datacontract.org/2004/07/DataServiceLibrary")]
        string SaveOrder(MVCandWCFAssignment.ProductsService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/SaveOrder", ReplyAction="http://tempuri.org/IProductsService/SaveOrderResponse")]
        System.Threading.Tasks.Task<string> SaveOrderAsync(MVCandWCFAssignment.ProductsService.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsServiceChannel : MVCandWCFAssignment.ProductsService.IProductsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsServiceClient : System.ServiceModel.ClientBase<MVCandWCFAssignment.ProductsService.IProductsService>, MVCandWCFAssignment.ProductsService.IProductsService {
        
        public ProductsServiceClient() {
        }
        
        public ProductsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public System.Threading.Tasks.Task<string> GetCategoriesAsync() {
            return base.Channel.GetCategoriesAsync();
        }
        
        public string GetProductsByID(int categoryID) {
            return base.Channel.GetProductsByID(categoryID);
        }
        
        public System.Threading.Tasks.Task<string> GetProductsByIDAsync(int categoryID) {
            return base.Channel.GetProductsByIDAsync(categoryID);
        }
        
        public string SaveOrder(MVCandWCFAssignment.ProductsService.Order order) {
            return base.Channel.SaveOrder(order);
        }
        
        public System.Threading.Tasks.Task<string> SaveOrderAsync(MVCandWCFAssignment.ProductsService.Order order) {
            return base.Channel.SaveOrderAsync(order);
        }
    }
}
