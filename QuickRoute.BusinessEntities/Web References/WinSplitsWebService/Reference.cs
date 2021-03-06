﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.239.
// 
#pragma warning disable 1591

namespace QuickRoute.BusinessEntities.WinSplitsWebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServicesSoap", Namespace="http://www.winsplits.se/")]
    public partial class WebServices : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetEventsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetCategoriesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRunnersAndSplitsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRunnersPerClubAndEventOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebServices() {
            this.Url = global::QuickRoute.BusinessEntities.Properties.Settings.Default.QuickRoute_BusinessEntities_WinSplitsWebService_WebServices;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetEventsCompletedEventHandler GetEventsCompleted;
        
        /// <remarks/>
        public event GetCategoriesCompletedEventHandler GetCategoriesCompleted;
        
        /// <remarks/>
        public event GetRunnersAndSplitsCompletedEventHandler GetRunnersAndSplitsCompleted;
        
        /// <remarks/>
        public event GetRunnersPerClubAndEventCompletedEventHandler GetRunnersPerClubAndEventCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.winsplits.se/GetEvents", RequestNamespace="http://www.winsplits.se/", ResponseNamespace="http://www.winsplits.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Event[] GetEvents(System.DateTime startDate, System.DateTime endDate, string country) {
            object[] results = this.Invoke("GetEvents", new object[] {
                        startDate,
                        endDate,
                        country});
            return ((Event[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEventsAsync(System.DateTime startDate, System.DateTime endDate, string country) {
            this.GetEventsAsync(startDate, endDate, country, null);
        }
        
        /// <remarks/>
        public void GetEventsAsync(System.DateTime startDate, System.DateTime endDate, string country, object userState) {
            if ((this.GetEventsOperationCompleted == null)) {
                this.GetEventsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEventsOperationCompleted);
            }
            this.InvokeAsync("GetEvents", new object[] {
                        startDate,
                        endDate,
                        country}, this.GetEventsOperationCompleted, userState);
        }
        
        private void OnGetEventsOperationCompleted(object arg) {
            if ((this.GetEventsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEventsCompleted(this, new GetEventsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.winsplits.se/GetCategories", RequestNamespace="http://www.winsplits.se/", ResponseNamespace="http://www.winsplits.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Category[] GetCategories(int databaseId) {
            object[] results = this.Invoke("GetCategories", new object[] {
                        databaseId});
            return ((Category[])(results[0]));
        }
        
        /// <remarks/>
        public void GetCategoriesAsync(int databaseId) {
            this.GetCategoriesAsync(databaseId, null);
        }
        
        /// <remarks/>
        public void GetCategoriesAsync(int databaseId, object userState) {
            if ((this.GetCategoriesOperationCompleted == null)) {
                this.GetCategoriesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetCategoriesOperationCompleted);
            }
            this.InvokeAsync("GetCategories", new object[] {
                        databaseId}, this.GetCategoriesOperationCompleted, userState);
        }
        
        private void OnGetCategoriesOperationCompleted(object arg) {
            if ((this.GetCategoriesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCategoriesCompleted(this, new GetCategoriesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.winsplits.se/GetRunnersAndSplits", RequestNamespace="http://www.winsplits.se/", ResponseNamespace="http://www.winsplits.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Runner[] GetRunnersAndSplits(int databaseId, short categoryIndex) {
            object[] results = this.Invoke("GetRunnersAndSplits", new object[] {
                        databaseId,
                        categoryIndex});
            return ((Runner[])(results[0]));
        }
        
        /// <remarks/>
        public void GetRunnersAndSplitsAsync(int databaseId, short categoryIndex) {
            this.GetRunnersAndSplitsAsync(databaseId, categoryIndex, null);
        }
        
        /// <remarks/>
        public void GetRunnersAndSplitsAsync(int databaseId, short categoryIndex, object userState) {
            if ((this.GetRunnersAndSplitsOperationCompleted == null)) {
                this.GetRunnersAndSplitsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRunnersAndSplitsOperationCompleted);
            }
            this.InvokeAsync("GetRunnersAndSplits", new object[] {
                        databaseId,
                        categoryIndex}, this.GetRunnersAndSplitsOperationCompleted, userState);
        }
        
        private void OnGetRunnersAndSplitsOperationCompleted(object arg) {
            if ((this.GetRunnersAndSplitsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRunnersAndSplitsCompleted(this, new GetRunnersAndSplitsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.winsplits.se/GetRunnersPerClubAndEvent", RequestNamespace="http://www.winsplits.se/", ResponseNamespace="http://www.winsplits.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public EventClubRunnerCount[] GetRunnersPerClubAndEvent(System.DateTime startDate, System.DateTime endDate, string country) {
            object[] results = this.Invoke("GetRunnersPerClubAndEvent", new object[] {
                        startDate,
                        endDate,
                        country});
            return ((EventClubRunnerCount[])(results[0]));
        }
        
        /// <remarks/>
        public void GetRunnersPerClubAndEventAsync(System.DateTime startDate, System.DateTime endDate, string country) {
            this.GetRunnersPerClubAndEventAsync(startDate, endDate, country, null);
        }
        
        /// <remarks/>
        public void GetRunnersPerClubAndEventAsync(System.DateTime startDate, System.DateTime endDate, string country, object userState) {
            if ((this.GetRunnersPerClubAndEventOperationCompleted == null)) {
                this.GetRunnersPerClubAndEventOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRunnersPerClubAndEventOperationCompleted);
            }
            this.InvokeAsync("GetRunnersPerClubAndEvent", new object[] {
                        startDate,
                        endDate,
                        country}, this.GetRunnersPerClubAndEventOperationCompleted, userState);
        }
        
        private void OnGetRunnersPerClubAndEventOperationCompleted(object arg) {
            if ((this.GetRunnersPerClubAndEventCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRunnersPerClubAndEventCompleted(this, new GetRunnersPerClubAndEventCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.winsplits.se/")]
    public partial class Event {
        
        private string nameField;
        
        private string organiserField;
        
        private System.DateTime startDateField;
        
        private int databaseIdField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Organiser {
            get {
                return this.organiserField;
            }
            set {
                this.organiserField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime StartDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        public int DatabaseId {
            get {
                return this.databaseIdField;
            }
            set {
                this.databaseIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.winsplits.se/")]
    public partial class ClubRunnerCount {
        
        private string clubField;
        
        private int noOfRunnersField;
        
        /// <remarks/>
        public string Club {
            get {
                return this.clubField;
            }
            set {
                this.clubField = value;
            }
        }
        
        /// <remarks/>
        public int NoOfRunners {
            get {
                return this.noOfRunnersField;
            }
            set {
                this.noOfRunnersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.winsplits.se/")]
    public partial class EventClubRunnerCount {
        
        private Event eventField;
        
        private ClubRunnerCount[] clubRunnerCountsField;
        
        /// <remarks/>
        public Event Event {
            get {
                return this.eventField;
            }
            set {
                this.eventField = value;
            }
        }
        
        /// <remarks/>
        public ClubRunnerCount[] ClubRunnerCounts {
            get {
                return this.clubRunnerCountsField;
            }
            set {
                this.clubRunnerCountsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.winsplits.se/")]
    public partial class Runner {
        
        private string nameField;
        
        private string clubField;
        
        private System.Nullable<System.DateTime> startTimeField;
        
        private System.Nullable<System.DateTime> finishTimeField;
        
        private System.DateTime[] splitsField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Club {
            get {
                return this.clubField;
            }
            set {
                this.clubField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> FinishTime {
            get {
                return this.finishTimeField;
            }
            set {
                this.finishTimeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime[] Splits {
            get {
                return this.splitsField;
            }
            set {
                this.splitsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.winsplits.se/")]
    public partial class Category {
        
        private string nameField;
        
        private int noOfRunnersField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int NoOfRunners {
            get {
                return this.noOfRunnersField;
            }
            set {
                this.noOfRunnersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetEventsCompletedEventHandler(object sender, GetEventsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Event[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Event[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetCategoriesCompletedEventHandler(object sender, GetCategoriesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCategoriesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCategoriesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Category[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Category[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetRunnersAndSplitsCompletedEventHandler(object sender, GetRunnersAndSplitsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRunnersAndSplitsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRunnersAndSplitsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Runner[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Runner[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetRunnersPerClubAndEventCompletedEventHandler(object sender, GetRunnersPerClubAndEventCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRunnersPerClubAndEventCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRunnersPerClubAndEventCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EventClubRunnerCount[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EventClubRunnerCount[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591