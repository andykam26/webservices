﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ConsumoClima.serverweather {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="clima_wsSoap", Namespace="http://tempuri.org/")]
    public partial class clima_ws : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SelectAllCityOperationCompleted;
        
        private System.Threading.SendOrPostCallback SelectListCityOperationCompleted;
        
        private System.Threading.SendOrPostCallback SelectCityByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertPronosticOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdatePronosticOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidateUserwsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public clima_ws() {
            this.Url = global::ConsumoClima.Properties.Settings.Default.ConsumoClima_serverweather_clima_ws;
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
        public event SelectAllCityCompletedEventHandler SelectAllCityCompleted;
        
        /// <remarks/>
        public event SelectListCityCompletedEventHandler SelectListCityCompleted;
        
        /// <remarks/>
        public event SelectCityByIdCompletedEventHandler SelectCityByIdCompleted;
        
        /// <remarks/>
        public event InsertPronosticCompletedEventHandler InsertPronosticCompleted;
        
        /// <remarks/>
        public event UpdatePronosticCompletedEventHandler UpdatePronosticCompleted;
        
        /// <remarks/>
        public event ValidateUserwsCompletedEventHandler ValidateUserwsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SelectAllCity", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet SelectAllCity() {
            object[] results = this.Invoke("SelectAllCity", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void SelectAllCityAsync() {
            this.SelectAllCityAsync(null);
        }
        
        /// <remarks/>
        public void SelectAllCityAsync(object userState) {
            if ((this.SelectAllCityOperationCompleted == null)) {
                this.SelectAllCityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectAllCityOperationCompleted);
            }
            this.InvokeAsync("SelectAllCity", new object[0], this.SelectAllCityOperationCompleted, userState);
        }
        
        private void OnSelectAllCityOperationCompleted(object arg) {
            if ((this.SelectAllCityCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectAllCityCompleted(this, new SelectAllCityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SelectListCity", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet SelectListCity() {
            object[] results = this.Invoke("SelectListCity", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void SelectListCityAsync() {
            this.SelectListCityAsync(null);
        }
        
        /// <remarks/>
        public void SelectListCityAsync(object userState) {
            if ((this.SelectListCityOperationCompleted == null)) {
                this.SelectListCityOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectListCityOperationCompleted);
            }
            this.InvokeAsync("SelectListCity", new object[0], this.SelectListCityOperationCompleted, userState);
        }
        
        private void OnSelectListCityOperationCompleted(object arg) {
            if ((this.SelectListCityCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectListCityCompleted(this, new SelectListCityCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SelectCityById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet SelectCityById(int ID) {
            object[] results = this.Invoke("SelectCityById", new object[] {
                        ID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void SelectCityByIdAsync(int ID) {
            this.SelectCityByIdAsync(ID, null);
        }
        
        /// <remarks/>
        public void SelectCityByIdAsync(int ID, object userState) {
            if ((this.SelectCityByIdOperationCompleted == null)) {
                this.SelectCityByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectCityByIdOperationCompleted);
            }
            this.InvokeAsync("SelectCityById", new object[] {
                        ID}, this.SelectCityByIdOperationCompleted, userState);
        }
        
        private void OnSelectCityByIdOperationCompleted(object arg) {
            if ((this.SelectCityByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectCityByIdCompleted(this, new SelectCityByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertPronostic", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int InsertPronostic(int id_ciudad, int id_clima, int velocidad_viento, int temperatura, int Posibilidad_lluvia, string Direccion_viento) {
            object[] results = this.Invoke("InsertPronostic", new object[] {
                        id_ciudad,
                        id_clima,
                        velocidad_viento,
                        temperatura,
                        Posibilidad_lluvia,
                        Direccion_viento});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void InsertPronosticAsync(int id_ciudad, int id_clima, int velocidad_viento, int temperatura, int Posibilidad_lluvia, string Direccion_viento) {
            this.InsertPronosticAsync(id_ciudad, id_clima, velocidad_viento, temperatura, Posibilidad_lluvia, Direccion_viento, null);
        }
        
        /// <remarks/>
        public void InsertPronosticAsync(int id_ciudad, int id_clima, int velocidad_viento, int temperatura, int Posibilidad_lluvia, string Direccion_viento, object userState) {
            if ((this.InsertPronosticOperationCompleted == null)) {
                this.InsertPronosticOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertPronosticOperationCompleted);
            }
            this.InvokeAsync("InsertPronostic", new object[] {
                        id_ciudad,
                        id_clima,
                        velocidad_viento,
                        temperatura,
                        Posibilidad_lluvia,
                        Direccion_viento}, this.InsertPronosticOperationCompleted, userState);
        }
        
        private void OnInsertPronosticOperationCompleted(object arg) {
            if ((this.InsertPronosticCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertPronosticCompleted(this, new InsertPronosticCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdatePronostic", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdatePronostic(int id_ciudad, int id_clima, int velocidad_viento, int temperatura, int Posibilidad_lluvia, string Direccion_viento) {
            object[] results = this.Invoke("UpdatePronostic", new object[] {
                        id_ciudad,
                        id_clima,
                        velocidad_viento,
                        temperatura,
                        Posibilidad_lluvia,
                        Direccion_viento});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void UpdatePronosticAsync(int id_ciudad, int id_clima, int velocidad_viento, int temperatura, int Posibilidad_lluvia, string Direccion_viento) {
            this.UpdatePronosticAsync(id_ciudad, id_clima, velocidad_viento, temperatura, Posibilidad_lluvia, Direccion_viento, null);
        }
        
        /// <remarks/>
        public void UpdatePronosticAsync(int id_ciudad, int id_clima, int velocidad_viento, int temperatura, int Posibilidad_lluvia, string Direccion_viento, object userState) {
            if ((this.UpdatePronosticOperationCompleted == null)) {
                this.UpdatePronosticOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdatePronosticOperationCompleted);
            }
            this.InvokeAsync("UpdatePronostic", new object[] {
                        id_ciudad,
                        id_clima,
                        velocidad_viento,
                        temperatura,
                        Posibilidad_lluvia,
                        Direccion_viento}, this.UpdatePronosticOperationCompleted, userState);
        }
        
        private void OnUpdatePronosticOperationCompleted(object arg) {
            if ((this.UpdatePronosticCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdatePronosticCompleted(this, new UpdatePronosticCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ValidateUserws", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ValidateUserws(string Usuario, string Contrasenia) {
            object[] results = this.Invoke("ValidateUserws", new object[] {
                        Usuario,
                        Contrasenia});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void ValidateUserwsAsync(string Usuario, string Contrasenia) {
            this.ValidateUserwsAsync(Usuario, Contrasenia, null);
        }
        
        /// <remarks/>
        public void ValidateUserwsAsync(string Usuario, string Contrasenia, object userState) {
            if ((this.ValidateUserwsOperationCompleted == null)) {
                this.ValidateUserwsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidateUserwsOperationCompleted);
            }
            this.InvokeAsync("ValidateUserws", new object[] {
                        Usuario,
                        Contrasenia}, this.ValidateUserwsOperationCompleted, userState);
        }
        
        private void OnValidateUserwsOperationCompleted(object arg) {
            if ((this.ValidateUserwsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidateUserwsCompleted(this, new ValidateUserwsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SelectAllCityCompletedEventHandler(object sender, SelectAllCityCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectAllCityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectAllCityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SelectListCityCompletedEventHandler(object sender, SelectListCityCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectListCityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectListCityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SelectCityByIdCompletedEventHandler(object sender, SelectCityByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectCityByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectCityByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void InsertPronosticCompletedEventHandler(object sender, InsertPronosticCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertPronosticCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertPronosticCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void UpdatePronosticCompletedEventHandler(object sender, UpdatePronosticCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdatePronosticCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdatePronosticCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ValidateUserwsCompletedEventHandler(object sender, ValidateUserwsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateUserwsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidateUserwsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591