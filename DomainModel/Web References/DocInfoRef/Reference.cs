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

namespace DomainModel.DocInfoRef {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="DocInfoSoap", Namespace="http://www.stellent.com/DocInfo/")]
    public partial class DocInfo : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DocInfoByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback DocInfoByNameOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DocInfo() {
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
        public event DocInfoByIDCompletedEventHandler DocInfoByIDCompleted;
        
        /// <remarks/>
        public event DocInfoByNameCompletedEventHandler DocInfoByNameCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.stellent.com/DocInfo/", RequestNamespace="http://www.stellent.com/DocInfo/", ResponseNamespace="http://www.stellent.com/DocInfo/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DocInfoByIDResult DocInfoByID(int dID, [System.Xml.Serialization.XmlIgnoreAttribute()] bool dIDSpecified, [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)] IdcProperty[] extraProps) {
            object[] results = this.Invoke("DocInfoByID", new object[] {
                        dID,
                        dIDSpecified,
                        extraProps});
            return ((DocInfoByIDResult)(results[0]));
        }
        
        /// <remarks/>
        public void DocInfoByIDAsync(int dID, bool dIDSpecified, IdcProperty[] extraProps) {
            this.DocInfoByIDAsync(dID, dIDSpecified, extraProps, null);
        }
        
        /// <remarks/>
        public void DocInfoByIDAsync(int dID, bool dIDSpecified, IdcProperty[] extraProps, object userState) {
            if ((this.DocInfoByIDOperationCompleted == null)) {
                this.DocInfoByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDocInfoByIDOperationCompleted);
            }
            this.InvokeAsync("DocInfoByID", new object[] {
                        dID,
                        dIDSpecified,
                        extraProps}, this.DocInfoByIDOperationCompleted, userState);
        }
        
        private void OnDocInfoByIDOperationCompleted(object arg) {
            if ((this.DocInfoByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DocInfoByIDCompleted(this, new DocInfoByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.stellent.com/DocInfo/", RequestNamespace="http://www.stellent.com/DocInfo/", ResponseNamespace="http://www.stellent.com/DocInfo/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DocInfoByNameResult DocInfoByName(string dDocName, [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)] IdcProperty[] extraProps) {
            object[] results = this.Invoke("DocInfoByName", new object[] {
                        dDocName,
                        extraProps});
            return ((DocInfoByNameResult)(results[0]));
        }
        
        /// <remarks/>
        public void DocInfoByNameAsync(string dDocName, IdcProperty[] extraProps) {
            this.DocInfoByNameAsync(dDocName, extraProps, null);
        }
        
        /// <remarks/>
        public void DocInfoByNameAsync(string dDocName, IdcProperty[] extraProps, object userState) {
            if ((this.DocInfoByNameOperationCompleted == null)) {
                this.DocInfoByNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDocInfoByNameOperationCompleted);
            }
            this.InvokeAsync("DocInfoByName", new object[] {
                        dDocName,
                        extraProps}, this.DocInfoByNameOperationCompleted, userState);
        }
        
        private void OnDocInfoByNameOperationCompleted(object arg) {
            if ((this.DocInfoByNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DocInfoByNameCompleted(this, new DocInfoByNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/DocInfo/")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/DocInfo/")]
    public partial class DocInfoByNameResult {
        
        private ContentInfo[] contentInfoField;
        
        private Revisions[] revisionsField;
        
        private WorkflowInfo[] workflowInfoField;
        
        private StatusInfo statusInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContentInfo")]
        public ContentInfo[] ContentInfo {
            get {
                return this.contentInfoField;
            }
            set {
                this.contentInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Revisions")]
        public Revisions[] Revisions {
            get {
                return this.revisionsField;
            }
            set {
                this.revisionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowInfo")]
        public WorkflowInfo[] WorkflowInfo {
            get {
                return this.workflowInfoField;
            }
            set {
                this.workflowInfoField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/DocInfo/")]
    public partial class ContentInfo {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/DocInfo/")]
    public partial class Revisions {
        
        private string dFormatField;
        
        private string dInDateField;
        
        private string dOutDateField;
        
        private string dStatusField;
        
        private string dProcessingStateField;
        
        private string dRevLabelField;
        
        private int dIDField;
        
        private bool dIDFieldSpecified;
        
        private string dDocNameField;
        
        private int dRevisionIDField;
        
        private bool dRevisionIDFieldSpecified;
        
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
        public string dProcessingState {
            get {
                return this.dProcessingStateField;
            }
            set {
                this.dProcessingStateField = value;
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
        public string dDocName {
            get {
                return this.dDocNameField;
            }
            set {
                this.dDocNameField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/DocInfo/")]
    public partial class WorkflowInfo {
        
        private int dWfIDField;
        
        private bool dWfIDFieldSpecified;
        
        private string dDocNameField;
        
        private string dWfDocStateField;
        
        private string dWfComputedField;
        
        private int dWfCurrentStepIDField;
        
        private bool dWfCurrentStepIDFieldSpecified;
        
        private string dWfDirectoryField;
        
        private string dClbraNameField;
        
        private string dWfNameField;
        
        private string dWfDescriptionField;
        
        private string dCompletionDateField;
        
        private string dSecurityGroupField;
        
        private string dWfStatusField;
        
        private string dWfTypeField;
        
        private string dProjectIDField;
        
        private bool dIsCollaborationField;
        
        private bool dIsCollaborationFieldSpecified;
        
        /// <remarks/>
        public int dWfID {
            get {
                return this.dWfIDField;
            }
            set {
                this.dWfIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dWfIDSpecified {
            get {
                return this.dWfIDFieldSpecified;
            }
            set {
                this.dWfIDFieldSpecified = value;
            }
        }
        
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
        public string dWfDocState {
            get {
                return this.dWfDocStateField;
            }
            set {
                this.dWfDocStateField = value;
            }
        }
        
        /// <remarks/>
        public string dWfComputed {
            get {
                return this.dWfComputedField;
            }
            set {
                this.dWfComputedField = value;
            }
        }
        
        /// <remarks/>
        public int dWfCurrentStepID {
            get {
                return this.dWfCurrentStepIDField;
            }
            set {
                this.dWfCurrentStepIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dWfCurrentStepIDSpecified {
            get {
                return this.dWfCurrentStepIDFieldSpecified;
            }
            set {
                this.dWfCurrentStepIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string dWfDirectory {
            get {
                return this.dWfDirectoryField;
            }
            set {
                this.dWfDirectoryField = value;
            }
        }
        
        /// <remarks/>
        public string dClbraName {
            get {
                return this.dClbraNameField;
            }
            set {
                this.dClbraNameField = value;
            }
        }
        
        /// <remarks/>
        public string dWfName {
            get {
                return this.dWfNameField;
            }
            set {
                this.dWfNameField = value;
            }
        }
        
        /// <remarks/>
        public string dWfDescription {
            get {
                return this.dWfDescriptionField;
            }
            set {
                this.dWfDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string dCompletionDate {
            get {
                return this.dCompletionDateField;
            }
            set {
                this.dCompletionDateField = value;
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
        public string dWfStatus {
            get {
                return this.dWfStatusField;
            }
            set {
                this.dWfStatusField = value;
            }
        }
        
        /// <remarks/>
        public string dWfType {
            get {
                return this.dWfTypeField;
            }
            set {
                this.dWfTypeField = value;
            }
        }
        
        /// <remarks/>
        public string dProjectID {
            get {
                return this.dProjectIDField;
            }
            set {
                this.dProjectIDField = value;
            }
        }
        
        /// <remarks/>
        public bool dIsCollaboration {
            get {
                return this.dIsCollaborationField;
            }
            set {
                this.dIsCollaborationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dIsCollaborationSpecified {
            get {
                return this.dIsCollaborationFieldSpecified;
            }
            set {
                this.dIsCollaborationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/DocInfo/")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.stellent.com/DocInfo/")]
    public partial class DocInfoByIDResult {
        
        private ContentInfo[] contentInfoField;
        
        private Revisions[] revisionsField;
        
        private WorkflowInfo[] workflowInfoField;
        
        private StatusInfo statusInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContentInfo")]
        public ContentInfo[] ContentInfo {
            get {
                return this.contentInfoField;
            }
            set {
                this.contentInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Revisions")]
        public Revisions[] Revisions {
            get {
                return this.revisionsField;
            }
            set {
                this.revisionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowInfo")]
        public WorkflowInfo[] WorkflowInfo {
            get {
                return this.workflowInfoField;
            }
            set {
                this.workflowInfoField = value;
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
    public delegate void DocInfoByIDCompletedEventHandler(object sender, DocInfoByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DocInfoByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DocInfoByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DocInfoByIDResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DocInfoByIDResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DocInfoByNameCompletedEventHandler(object sender, DocInfoByNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DocInfoByNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DocInfoByNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DocInfoByNameResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DocInfoByNameResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591