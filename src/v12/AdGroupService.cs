﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.2407.
// 
namespace com.google.api.adwords.v12 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AdGroupServiceSoapBinding", Namespace="https://adwords.google.com/api/adwords/v12")]
    public class AdGroupService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public useragent useragentValue;
        
        public password passwordValue;
        
        public email emailValue;
        
        public clientEmail clientEmailValue;
        
        public clientCustomerId clientCustomerIdValue;
        
        public developerToken developerTokenValue;
        
        public applicationToken applicationTokenValue;
        
        public responseTime responseTimeValue;
        
        public operations operationsValue;
        
        public units unitsValue;
        
        public requestId requestIdValue;
        
        /// <remarks/>
        public AdGroupService() {
            this.Url = "https://adwords.google.com/api/adwords/v12/AdGroupService";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v12", ResponseNamespace="https://adwords.google.com/api/adwords/v12", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("addAdGroupReturn")]
        public AdGroup addAdGroup(int campaignID, AdGroup newData) {
            object[] results = this.Invoke("addAdGroup", new object[] {
                        campaignID,
                        newData});
            return ((AdGroup)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginaddAdGroup(int campaignID, AdGroup newData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("addAdGroup", new object[] {
                        campaignID,
                        newData}, callback, asyncState);
        }
        
        /// <remarks/>
        public AdGroup EndaddAdGroup(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((AdGroup)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v12", ResponseNamespace="https://adwords.google.com/api/adwords/v12", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("addAdGroupListReturn")]
        public AdGroup[] addAdGroupList(int campaignID, [System.Xml.Serialization.XmlElementAttribute("newData")] AdGroup[] newData) {
            object[] results = this.Invoke("addAdGroupList", new object[] {
                        campaignID,
                        newData});
            return ((AdGroup[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginaddAdGroupList(int campaignID, AdGroup[] newData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("addAdGroupList", new object[] {
                        campaignID,
                        newData}, callback, asyncState);
        }
        
        /// <remarks/>
        public AdGroup[] EndaddAdGroupList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((AdGroup[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v12", ResponseNamespace="https://adwords.google.com/api/adwords/v12", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAdGroupReturn")]
        public AdGroup getAdGroup(long adGroupId) {
            object[] results = this.Invoke("getAdGroup", new object[] {
                        adGroupId});
            return ((AdGroup)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAdGroup(long adGroupId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAdGroup", new object[] {
                        adGroupId}, callback, asyncState);
        }
        
        /// <remarks/>
        public AdGroup EndgetAdGroup(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((AdGroup)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v12", ResponseNamespace="https://adwords.google.com/api/adwords/v12", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAdGroupListReturn")]
        public AdGroup[] getAdGroupList([System.Xml.Serialization.XmlElementAttribute("adgroupIDs")] long[] adgroupIDs) {
            object[] results = this.Invoke("getAdGroupList", new object[] {
                        adgroupIDs});
            return ((AdGroup[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAdGroupList(long[] adgroupIDs, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAdGroupList", new object[] {
                        adgroupIDs}, callback, asyncState);
        }
        
        /// <remarks/>
        public AdGroup[] EndgetAdGroupList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((AdGroup[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v12", ResponseNamespace="https://adwords.google.com/api/adwords/v12", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAdGroupStatsReturn")]
        public StatsRecord[] getAdGroupStats(int campaignId, [System.Xml.Serialization.XmlElementAttribute("adGroupIds")] long[] adGroupIds, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime startDay, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime endDay) {
            object[] results = this.Invoke("getAdGroupStats", new object[] {
                        campaignId,
                        adGroupIds,
                        startDay,
                        endDay});
            return ((StatsRecord[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAdGroupStats(int campaignId, long[] adGroupIds, System.DateTime startDay, System.DateTime endDay, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAdGroupStats", new object[] {
                        campaignId,
                        adGroupIds,
                        startDay,
                        endDay}, callback, asyncState);
        }
        
        /// <remarks/>
        public StatsRecord[] EndgetAdGroupStats(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StatsRecord[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v12", ResponseNamespace="https://adwords.google.com/api/adwords/v12", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAllAdGroupsReturn")]
        public AdGroup[] getAllAdGroups(int campaignID) {
            object[] results = this.Invoke("getAllAdGroups", new object[] {
                        campaignID});
            return ((AdGroup[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAllAdGroups(int campaignID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAllAdGroups", new object[] {
                        campaignID}, callback, asyncState);
        }
        
        /// <remarks/>
        public AdGroup[] EndgetAllAdGroups(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((AdGroup[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v12", ResponseNamespace="https://adwords.google.com/api/adwords/v12", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateAdGroup(AdGroup changedData) {
            this.Invoke("updateAdGroup", new object[] {
                        changedData});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginupdateAdGroup(AdGroup changedData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updateAdGroup", new object[] {
                        changedData}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndupdateAdGroup(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v12", ResponseNamespace="https://adwords.google.com/api/adwords/v12", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateAdGroupList([System.Xml.Serialization.XmlElementAttribute("changedData")] AdGroup[] changedData) {
            this.Invoke("updateAdGroupList", new object[] {
                        changedData});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginupdateAdGroupList(AdGroup[] changedData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updateAdGroupList", new object[] {
                        changedData}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndupdateAdGroupList(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v12")]
    public class AdGroup {
        
        /// <remarks/>
        public int campaignId;
        
        /// <remarks/>
        public long id;
        
        /// <remarks/>
        public long keywordContentMaxCpc;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool keywordContentMaxCpcSpecified;
        
        /// <remarks/>
        public long keywordMaxCpc;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool keywordMaxCpcSpecified;
        
        /// <remarks/>
        public long maxCpa;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxCpaSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string name;
        
        /// <remarks/>
        public long proxyKeywordMaxCpc;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool proxyKeywordMaxCpcSpecified;
        
        /// <remarks/>
        public long siteMaxCpc;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool siteMaxCpcSpecified;
        
        /// <remarks/>
        public long siteMaxCpm;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool siteMaxCpmSpecified;
        
        /// <remarks/>
        public AdGroupStatus status;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v12")]
    public enum AdGroupStatus {
        
        /// <remarks/>
        Enabled,
        
        /// <remarks/>
        Paused,
        
        /// <remarks/>
        Deleted,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v12")]
    public class StatsRecord {
        
        /// <remarks/>
        public System.Double averagePosition;
        
        /// <remarks/>
        public long clicks;
        
        /// <remarks/>
        public System.Double conversionRate;
        
        /// <remarks/>
        public long conversions;
        
        /// <remarks/>
        public long cost;
        
        /// <remarks/>
        public long id;
        
        /// <remarks/>
        public long impressions;
    }
}
