﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный текст был создан автоматически: Microsoft.VSDesigner, версия: 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace DomainModel.GetFileRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GetFileSoap", Namespace="http://www.stellent.com/GetFile/")]
    public partial class GetFile : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetFileByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFileByNameOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GetFile() {
            this.Url = global::DomainModel.Properties.Settings.Default.DomainModel_DocInfoRef_DocInfo;
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
        public event GetFileByIDCompletedEventHandler GetFileByIDCompleted;
        
        /// <remarks/>
        public event GetFileByNameCompletedEventHandler GetFileByNameCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.stellent.com/GetFile/", RequestNamespace="http://www.stellent.com/GetFile/", ResponseNamespace="http://www.stellent.com/GetFile/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GetFileByIDResult GetFileByID(int dID, [System.Xml.Serialization.XmlIgnoreAttribute()] bool dIDSpecified, string rendition, [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)] IdcProperty[] extraProps) {
            object[] results = this.Invoke("GetFileByID", new object[] {
                        dID,
                        dIDSpecified,
                        rendition,
                        extraProps});
            return ((GetFileByIDResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetFileByIDAsync(int dID, bool dIDSpecified, string rendition, IdcProperty[] extraProps) {
            this.GetFileByIDAsync(dID, dIDSpecified, rendition, extraProps, null);
        }
        
        /// <remarks/>
        public void GetFileByIDAsync(int dID, bool dIDSpecified, string rendition, IdcProperty[] extraProps, object userState) {
            if ((this.GetFileByIDOperationCompleted == null)) {
                this.GetFileByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileByIDOperationCompleted);
            }
            this.InvokeAsync("GetFileByID", new object[] {
                        dID,
                        dIDSpecified,
                        rendition,
                        extraProps}, this.GetFileByIDOperationCompleted, userState);
        }
        
        private void OnGetFileByIDOperationCompleted(object arg) {
            if ((this.GetFileByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileByIDCompleted(this, new GetFileByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.stellent.com/GetFile/", RequestNamespace="http://www.stellent.com/GetFile/", ResponseNamespace="http://www.stellent.com/GetFile/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GetFileByNameResult GetFileByName(string dDocName, string revisionSelectionMethod, string rendition, [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)] IdcProperty[] extraProps) {
            object[] results = this.Invoke("GetFileByName", new object[] {
                        dDocName,
                        revisionSelectionMethod,
                        rendition,
                        extraProps});
            return ((GetFileByNameResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetFileByNameAsync(string dDocName, string revisionSelectionMethod, string rendition, IdcProperty[] extraProps) {
            this.GetFileByNameAsync(dDocName, revisionSelectionMethod, rendition, extraProps, null);
        }
        
        /// <remarks/>
        public void GetFileByNameAsync(string dDocName, string revisionSelectionMethod, string rendition, IdcProperty[] extraProps, object userState) {
            if ((this.GetFileByNameOperationCompleted == null)) {
                this.GetFileByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFileByNameOperationCompleted);
            }
            this.InvokeAsync("GetFileByName", new object[] {
                        dDocName,
                        revisionSelectionMethod,
                        rendition,
                        extraProps}, this.GetFileByNameOperationCompleted, userState);
        }
        
        private void OnGetFileByNameOperationCompleted(object arg) {
            if ((this.GetFileByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFileByNameCompleted(this, new GetFileByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/GetFile/")]
    public partial class IdcProperty {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/GetFile/")]
    public partial class GetFileByNameResult {
        
        private FileInfo[] fileInfoField;
        
        private IdcFile downloadFileField;
        
        private StatusInfo statusInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FileInfo")]
        public FileInfo[] FileInfo {
            get {
                return this.fileInfoField;
            }
            set {
                this.fileInfoField = value;
            }
        }
        
        /// <remarks/>
        public IdcFile downloadFile {
            get {
                return this.downloadFileField;
            }
            set {
                this.downloadFileField = value;
            }
        }
        
        /// <remarks/>
        public StatusInfo StatusInfo {
            get {
                return this.statusInfoField;
            }
            set {
                this.statusInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/GetFile/")]
    public partial class FileInfo {
        
        private string dDocNameField;
        
        private string dDocTitleField;
        
        private string dDocTypeField;
        
        private string dDocAuthorField;
        
        private string dSecurityGroupField;
        
        private string dDocAccountField;
        
        private int xLichnost_IDField;
        
        private bool xLichnost_IDFieldSpecified;
        
        private int dIDField;
        
        private bool dIDFieldSpecified;
        
        private int dRevClassIDField;
        
        private bool dRevClassIDFieldSpecified;
        
        private int dRevisionIDField;
        
        private bool dRevisionIDFieldSpecified;
        
        private string dRevLabelField;
        
        private bool dIsCheckedOutField;
        
        private bool dIsCheckedOutFieldSpecified;
        
        private string dCheckoutUserField;
        
        private string dCreateDateField;
        
        private string dInDateField;
        
        private string dOutDateField;
        
        private string dStatusField;
        
        private string dReleaseStateField;
        
        private string dFlag1Field;
        
        private string dWebExtensionField;
        
        private string dProcessingStateField;
        
        private string dMessageField;
        
        private string dReleaseDateField;
        
        private string dRendition1Field;
        
        private string dRendition2Field;
        
        private string dIndexerStateField;
        
        private string dPublishTypeField;
        
        private string dPublishStateField;
        
        private int dDocIDField;
        
        private bool dDocIDFieldSpecified;
        
        private bool dIsPrimaryField;
        
        private bool dIsPrimaryFieldSpecified;
        
        private bool dIsWebFormatField;
        
        private bool dIsWebFormatFieldSpecified;
        
        private string dLocationField;
        
        private string dOriginalNameField;
        
        private string dFormatField;
        
        private string dExtensionField;
        
        private int dFileSizeField;
        
        private bool dFileSizeFieldSpecified;
        
        private IdcProperty[] customDocMetaDataField;
        
        /// <remarks/>
        public string dDocName {
            get {
                return this.dDocNameField;
            }
            set {
                this.dDocNameField = value;
            }
        }
        
        /// <remarks/>
        public string dDocTitle {
            get {
                return this.dDocTitleField;
            }
            set {
                this.dDocTitleField = value;
            }
        }
        
        /// <remarks/>
        public string dDocType {
            get {
                return this.dDocTypeField;
            }
            set {
                this.dDocTypeField = value;
            }
        }
        
        /// <remarks/>
        public string dDocAuthor {
            get {
                return this.dDocAuthorField;
            }
            set {
                this.dDocAuthorField = value;
            }
        }
        
        /// <remarks/>
        public string dSecurityGroup {
            get {
                return this.dSecurityGroupField;
            }
            set {
                this.dSecurityGroupField = value;
            }
        }
        
        /// <remarks/>
        public string dDocAccount {
            get {
                return this.dDocAccountField;
            }
            set {
                this.dDocAccountField = value;
            }
        }
        
        /// <remarks/>
        public int xLichnost_ID {
            get {
                return this.xLichnost_IDField;
            }
            set {
                this.xLichnost_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xLichnost_IDSpecified {
            get {
                return this.xLichnost_IDFieldSpecified;
            }
            set {
                this.xLichnost_IDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int dID {
            get {
                return this.dIDField;
            }
            set {
                this.dIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dIDSpecified {
            get {
                return this.dIDFieldSpecified;
            }
            set {
                this.dIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int dRevClassID {
            get {
                return this.dRevClassIDField;
            }
            set {
                this.dRevClassIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dRevClassIDSpecified {
            get {
                return this.dRevClassIDFieldSpecified;
            }
            set {
                this.dRevClassIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int dRevisionID {
            get {
                return this.dRevisionIDField;
            }
            set {
                this.dRevisionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dRevisionIDSpecified {
            get {
                return this.dRevisionIDFieldSpecified;
            }
            set {
                this.dRevisionIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string dRevLabel {
            get {
                return this.dRevLabelField;
            }
            set {
                this.dRevLabelField = value;
            }
        }
        
        /// <remarks/>
        public bool dIsCheckedOut {
            get {
                return this.dIsCheckedOutField;
            }
            set {
                this.dIsCheckedOutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dIsCheckedOutSpecified {
            get {
                return this.dIsCheckedOutFieldSpecified;
            }
            set {
                this.dIsCheckedOutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string dCheckoutUser {
            get {
                return this.dCheckoutUserField;
            }
            set {
                this.dCheckoutUserField = value;
            }
        }
        
        /// <remarks/>
        public string dCreateDate {
            get {
                return this.dCreateDateField;
            }
            set {
                this.dCreateDateField = value;
            }
        }
        
        /// <remarks/>
        public string dInDate {
            get {
                return this.dInDateField;
            }
            set {
                this.dInDateField = value;
            }
        }
        
        /// <remarks/>
        public string dOutDate {
            get {
                return this.dOutDateField;
            }
            set {
                this.dOutDateField = value;
            }
        }
        
        /// <remarks/>
        public string dStatus {
            get {
                return this.dStatusField;
            }
            set {
                this.dStatusField = value;
            }
        }
        
        /// <remarks/>
        public string dReleaseState {
            get {
                return this.dReleaseStateField;
            }
            set {
                this.dReleaseStateField = value;
            }
        }
        
        /// <remarks/>
        public string dFlag1 {
            get {
                return this.dFlag1Field;
            }
            set {
                this.dFlag1Field = value;
            }
        }
        
        /// <remarks/>
        public string dWebExtension {
            get {
                return this.dWebExtensionField;
            }
            set {
                this.dWebExtensionField = value;
            }
        }
        
        /// <remarks/>
        public string dProcessingState {
            get {
                return this.dProcessingStateField;
            }
            set {
                this.dProcessingStateField = value;
            }
        }
        
        /// <remarks/>
        public string dMessage {
            get {
                return this.dMessageField;
            }
            set {
                this.dMessageField = value;
            }
        }
        
        /// <remarks/>
        public string dReleaseDate {
            get {
                return this.dReleaseDateField;
            }
            set {
                this.dReleaseDateField = value;
            }
        }
        
        /// <remarks/>
        public string dRendition1 {
            get {
                return this.dRendition1Field;
            }
            set {
                this.dRendition1Field = value;
            }
        }
        
        /// <remarks/>
        public string dRendition2 {
            get {
                return this.dRendition2Field;
            }
            set {
                this.dRendition2Field = value;
            }
        }
        
        /// <remarks/>
        public string dIndexerState {
            get {
                return this.dIndexerStateField;
            }
            set {
                this.dIndexerStateField = value;
            }
        }
        
        /// <remarks/>
        public string dPublishType {
            get {
                return this.dPublishTypeField;
            }
            set {
                this.dPublishTypeField = value;
            }
        }
        
        /// <remarks/>
        public string dPublishState {
            get {
                return this.dPublishStateField;
            }
            set {
                this.dPublishStateField = value;
            }
        }
        
        /// <remarks/>
        public int dDocID {
            get {
                return this.dDocIDField;
            }
            set {
                this.dDocIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dDocIDSpecified {
            get {
                return this.dDocIDFieldSpecified;
            }
            set {
                this.dDocIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool dIsPrimary {
            get {
                return this.dIsPrimaryField;
            }
            set {
                this.dIsPrimaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dIsPrimarySpecified {
            get {
                return this.dIsPrimaryFieldSpecified;
            }
            set {
                this.dIsPrimaryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool dIsWebFormat {
            get {
                return this.dIsWebFormatField;
            }
            set {
                this.dIsWebFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dIsWebFormatSpecified {
            get {
                return this.dIsWebFormatFieldSpecified;
            }
            set {
                this.dIsWebFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string dLocation {
            get {
                return this.dLocationField;
            }
            set {
                this.dLocationField = value;
            }
        }
        
        /// <remarks/>
        public string dOriginalName {
            get {
                return this.dOriginalNameField;
            }
            set {
                this.dOriginalNameField = value;
            }
        }
        
        /// <remarks/>
        public string dFormat {
            get {
                return this.dFormatField;
            }
            set {
                this.dFormatField = value;
            }
        }
        
        /// <remarks/>
        public string dExtension {
            get {
                return this.dExtensionField;
            }
            set {
                this.dExtensionField = value;
            }
        }
        
        /// <remarks/>
        public int dFileSize {
            get {
                return this.dFileSizeField;
            }
            set {
                this.dFileSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dFileSizeSpecified {
            get {
                return this.dFileSizeFieldSpecified;
            }
            set {
                this.dFileSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)]
        public IdcProperty[] CustomDocMetaData {
            get {
                return this.customDocMetaDataField;
            }
            set {
                this.customDocMetaDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/GetFile/")]
    public partial class IdcFile {
        
        private string fileNameField;
        
        private byte[] fileContentField;
        
        /// <remarks/>
        public string fileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] fileContent {
            get {
                return this.fileContentField;
            }
            set {
                this.fileContentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/GetFile/")]
    public partial class StatusInfo {
        
        private int statusCodeField;
        
        private bool statusCodeFieldSpecified;
        
        private string statusMessageField;
        
        /// <remarks/>
        public int statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusCodeSpecified {
            get {
                return this.statusCodeFieldSpecified;
            }
            set {
                this.statusCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string statusMessage {
            get {
                return this.statusMessageField;
            }
            set {
                this.statusMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/GetFile/")]
    public partial class GetFileByIDResult {
        
        private FileInfo[] fileInfoField;
        
        private IdcFile downloadFileField;
        
        private StatusInfo statusInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FileInfo")]
        public FileInfo[] FileInfo {
            get {
                return this.fileInfoField;
            }
            set {
                this.fileInfoField = value;
            }
        }
        
        /// <remarks/>
        public IdcFile downloadFile {
            get {
                return this.downloadFileField;
            }
            set {
                this.downloadFileField = value;
            }
        }
        
        /// <remarks/>
        public StatusInfo StatusInfo {
            get {
                return this.statusInfoField;
            }
            set {
                this.statusInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetFileByIDCompletedEventHandler(object sender, GetFileByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFileByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetFileByIDResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetFileByIDResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetFileByNameCompletedEventHandler(object sender, GetFileByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFileByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFileByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetFileByNameResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetFileByNameResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591