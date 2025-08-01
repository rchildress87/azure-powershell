// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.PowerShell;

    /// <summary>BmcKeySet represents the baseboard management controller key set.</summary>
    [System.ComponentModel.TypeConverter(typeof(BmcKeySetTypeConverter))]
    public partial class BmcKeySet
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BmcKeySet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BmcKeySet(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BmcKeySetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("AzureGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).AzureGroupId = (string) content.GetValueForProperty("AzureGroupId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).AzureGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("DetailedStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).DetailedStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetDetailedStatus?) content.GetValueForProperty("DetailedStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).DetailedStatus, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetDetailedStatus.CreateFrom);
            }
            if (content.Contains("DetailedStatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).DetailedStatusMessage = (string) content.GetValueForProperty("DetailedStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).DetailedStatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("Expiration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Expiration = (global::System.DateTime) content.GetValueForProperty("Expiration",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Expiration, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).LastValidation = (global::System.DateTime?) content.GetValueForProperty("LastValidation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).LastValidation, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PrivilegeLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).PrivilegeLevel = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetPrivilegeLevel) content.GetValueForProperty("PrivilegeLevel",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).PrivilegeLevel, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetPrivilegeLevel.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetProvisioningState.CreateFrom);
            }
            if (content.Contains("UserList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).UserList = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKeySetUser[]) content.GetValueForProperty("UserList",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).UserList, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKeySetUser>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KeySetUserTypeConverter.ConvertFrom));
            }
            if (content.Contains("UserListStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).UserListStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKeySetUserStatus[]) content.GetValueForProperty("UserListStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).UserListStatus, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKeySetUserStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KeySetUserStatusTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BmcKeySet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BmcKeySet(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BmcKeySetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("AzureGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).AzureGroupId = (string) content.GetValueForProperty("AzureGroupId",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).AzureGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("DetailedStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).DetailedStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetDetailedStatus?) content.GetValueForProperty("DetailedStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).DetailedStatus, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetDetailedStatus.CreateFrom);
            }
            if (content.Contains("DetailedStatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).DetailedStatusMessage = (string) content.GetValueForProperty("DetailedStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).DetailedStatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("Expiration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Expiration = (global::System.DateTime) content.GetValueForProperty("Expiration",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).Expiration, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).LastValidation = (global::System.DateTime?) content.GetValueForProperty("LastValidation",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).LastValidation, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PrivilegeLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).PrivilegeLevel = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetPrivilegeLevel) content.GetValueForProperty("PrivilegeLevel",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).PrivilegeLevel, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetPrivilegeLevel.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.BmcKeySetProvisioningState.CreateFrom);
            }
            if (content.Contains("UserList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).UserList = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKeySetUser[]) content.GetValueForProperty("UserList",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).UserList, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKeySetUser>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KeySetUserTypeConverter.ConvertFrom));
            }
            if (content.Contains("UserListStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).UserListStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKeySetUserStatus[]) content.GetValueForProperty("UserListStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySetInternal)this).UserListStatus, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKeySetUserStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KeySetUserStatusTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BmcKeySet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySet" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySet DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BmcKeySet(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BmcKeySet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySet" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySet DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BmcKeySet(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BmcKeySet" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="BmcKeySet" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBmcKeySet FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// BmcKeySet represents the baseboard management controller key set.
    [System.ComponentModel.TypeConverter(typeof(BmcKeySetTypeConverter))]
    public partial interface IBmcKeySet

    {

    }
}