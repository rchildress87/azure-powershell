// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Properties of NetworkSecurityPerimeterConfiguration</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class NetworkSecurityPerimeterConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApplicableFeature" /> property.</summary>
        private System.Collections.Generic.List<string> _applicableFeature;

        /// <summary>
        /// Indicates that the NSP controls related to backing association are only applicable to a specific feature in backing resource's
        /// data plane.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ApplicableFeature { get => this._applicableFeature; }

        /// <summary>Backing field for <see cref="IsBackingResource" /> property.</summary>
        private bool? _isBackingResource;

        /// <summary>
        /// True if the EventHub namespace is backed by another Azure resource and not visible to end users.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public bool? IsBackingResource { get => this._isBackingResource; }

        /// <summary>Internal Acessors for ApplicableFeature</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ApplicableFeature { get => this._applicableFeature; set { {_applicableFeature = value;} } }

        /// <summary>Internal Acessors for IsBackingResource</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.IsBackingResource { get => this._isBackingResource; set { {_isBackingResource = value;} } }

        /// <summary>Internal Acessors for NetworkSecurityPerimeter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeter Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.NetworkSecurityPerimeter { get => (this._networkSecurityPerimeter = this._networkSecurityPerimeter ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NetworkSecurityPerimeter()); set { {_networkSecurityPerimeter = value;} } }

        /// <summary>Internal Acessors for NetworkSecurityPerimeterGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.NetworkSecurityPerimeterGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).PerimeterGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).PerimeterGuid = value ?? null; }

        /// <summary>Internal Acessors for NetworkSecurityPerimeterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.NetworkSecurityPerimeterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Id = value ?? null; }

        /// <summary>Internal Acessors for NetworkSecurityPerimeterLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.NetworkSecurityPerimeterLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Location = value ?? null; }

        /// <summary>Internal Acessors for ParentAssociationName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ParentAssociationName { get => this._parentAssociationName; set { {_parentAssociationName = value;} } }

        /// <summary>Internal Acessors for Profile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfile Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.Profile { get => (this._profile = this._profile ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NetworkSecurityPerimeterConfigurationPropertiesProfile()); set { {_profile = value;} } }

        /// <summary>Internal Acessors for ProfileAccessRule</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule> Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProfileAccessRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).AccessRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).AccessRule = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProfileAccessRulesVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProfileAccessRulesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).AccessRulesVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).AccessRulesVersion = value ?? null; }

        /// <summary>Internal Acessors for ProfileName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).Name = value ?? null; }

        /// <summary>Internal Acessors for ResourceAssociation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociation Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ResourceAssociation { get => (this._resourceAssociation = this._resourceAssociation ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NetworkSecurityPerimeterConfigurationPropertiesResourceAssociation()); set { {_resourceAssociation = value;} } }

        /// <summary>Internal Acessors for ResourceAssociationAccessMode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ResourceAssociationAccessMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociationInternal)ResourceAssociation).AccessMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociationInternal)ResourceAssociation).AccessMode = value ?? null; }

        /// <summary>Internal Acessors for ResourceAssociationName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ResourceAssociationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociationInternal)ResourceAssociation).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociationInternal)ResourceAssociation).Name = value ?? null; }

        /// <summary>Internal Acessors for SourceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.SourceResourceId { get => this._sourceResourceId; set { {_sourceResourceId = value;} } }

        /// <summary>Backing field for <see cref="NetworkSecurityPerimeter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeter _networkSecurityPerimeter;

        /// <summary>NetworkSecurityPerimeter related information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeter NetworkSecurityPerimeter { get => (this._networkSecurityPerimeter = this._networkSecurityPerimeter ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NetworkSecurityPerimeter()); }

        /// <summary>Guid of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string NetworkSecurityPerimeterGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).PerimeterGuid; }

        /// <summary>Fully qualified identifier of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string NetworkSecurityPerimeterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Id; }

        /// <summary>Location of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string NetworkSecurityPerimeterLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Location; }

        /// <summary>Backing field for <see cref="ParentAssociationName" /> property.</summary>
        private string _parentAssociationName;

        /// <summary>Source Resource Association name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string ParentAssociationName { get => this._parentAssociationName; }

        /// <summary>Backing field for <see cref="Profile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfile _profile;

        /// <summary>Information about current network profile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfile Profile { get => (this._profile = this._profile ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NetworkSecurityPerimeterConfigurationPropertiesProfile()); }

        /// <summary>List of Access Rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule> ProfileAccessRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).AccessRule; }

        /// <summary>Current access rules version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string ProfileAccessRulesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).AccessRulesVersion; }

        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfileInternal)Profile).Name; }

        /// <summary>Backing field for <see cref="ProvisioningIssue" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IProvisioningIssue> _provisioningIssue;

        /// <summary>List of Provisioning Issues if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IProvisioningIssue> ProvisioningIssue { get => this._provisioningIssue; set => this._provisioningIssue = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of NetworkSecurityPerimeter configuration propagation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="ResourceAssociation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociation _resourceAssociation;

        /// <summary>Information about resource association</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociation ResourceAssociation { get => (this._resourceAssociation = this._resourceAssociation ?? new Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NetworkSecurityPerimeterConfigurationPropertiesResourceAssociation()); }

        /// <summary>Access Mode of the resource association</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string ResourceAssociationAccessMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociationInternal)ResourceAssociation).AccessMode; }

        /// <summary>Name of the resource association</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Inlined)]
        public string ResourceAssociationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociationInternal)ResourceAssociation).Name; }

        /// <summary>Backing field for <see cref="SourceResourceId" /> property.</summary>
        private string _sourceResourceId;

        /// <summary>ARM Id of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public string SourceResourceId { get => this._sourceResourceId; }

        /// <summary>
        /// Creates an new <see cref="NetworkSecurityPerimeterConfigurationProperties" /> instance.
        /// </summary>
        public NetworkSecurityPerimeterConfigurationProperties()
        {

        }
    }
    /// Properties of NetworkSecurityPerimeterConfiguration
    public partial interface INetworkSecurityPerimeterConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates that the NSP controls related to backing association are only applicable to a specific feature in backing resource's
        /// data plane.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Indicates that the NSP controls related to backing association are only applicable to a specific feature in backing resource's data plane.",
        SerializedName = @"applicableFeatures",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ApplicableFeature { get;  }
        /// <summary>
        /// True if the EventHub namespace is backed by another Azure resource and not visible to end users.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"True if the EventHub namespace is backed by another Azure resource and not visible to end users.",
        SerializedName = @"isBackingResource",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsBackingResource { get;  }
        /// <summary>Guid of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Guid of the resource",
        SerializedName = @"perimeterGuid",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityPerimeterGuid { get;  }
        /// <summary>Fully qualified identifier of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Fully qualified identifier of the resource",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityPerimeterId { get;  }
        /// <summary>Location of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Location of the resource",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityPerimeterLocation { get;  }
        /// <summary>Source Resource Association name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Source Resource Association name",
        SerializedName = @"parentAssociationName",
        PossibleTypes = new [] { typeof(string) })]
        string ParentAssociationName { get;  }
        /// <summary>List of Access Rules</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of Access Rules",
        SerializedName = @"accessRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule> ProfileAccessRule { get;  }
        /// <summary>Current access rules version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Current access rules version",
        SerializedName = @"accessRulesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileAccessRulesVersion { get;  }
        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the resource",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileName { get;  }
        /// <summary>List of Provisioning Issues if any</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Provisioning Issues if any",
        SerializedName = @"provisioningIssues",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IProvisioningIssue) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IProvisioningIssue> ProvisioningIssue { get; set; }
        /// <summary>Provisioning state of NetworkSecurityPerimeter configuration propagation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Provisioning state of NetworkSecurityPerimeter configuration propagation",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Unknown", "Creating", "Updating", "Accepted", "InvalidResponse", "Succeeded", "SucceededWithIssues", "Failed", "Deleting", "Deleted", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Access Mode of the resource association</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Access Mode of the resource association",
        SerializedName = @"accessMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("NoAssociationMode", "EnforcedMode", "LearningMode", "AuditMode", "UnspecifiedMode")]
        string ResourceAssociationAccessMode { get;  }
        /// <summary>Name of the resource association</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the resource association",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAssociationName { get;  }
        /// <summary>ARM Id of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ARM Id of source resource",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceResourceId { get;  }

    }
    /// Properties of NetworkSecurityPerimeterConfiguration
    internal partial interface INetworkSecurityPerimeterConfigurationPropertiesInternal

    {
        /// <summary>
        /// Indicates that the NSP controls related to backing association are only applicable to a specific feature in backing resource's
        /// data plane.
        /// </summary>
        System.Collections.Generic.List<string> ApplicableFeature { get; set; }
        /// <summary>
        /// True if the EventHub namespace is backed by another Azure resource and not visible to end users.
        /// </summary>
        bool? IsBackingResource { get; set; }
        /// <summary>NetworkSecurityPerimeter related information</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeter NetworkSecurityPerimeter { get; set; }
        /// <summary>Guid of the resource</summary>
        string NetworkSecurityPerimeterGuid { get; set; }
        /// <summary>Fully qualified identifier of the resource</summary>
        string NetworkSecurityPerimeterId { get; set; }
        /// <summary>Location of the resource</summary>
        string NetworkSecurityPerimeterLocation { get; set; }
        /// <summary>Source Resource Association name</summary>
        string ParentAssociationName { get; set; }
        /// <summary>Information about current network profile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesProfile Profile { get; set; }
        /// <summary>List of Access Rules</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule> ProfileAccessRule { get; set; }
        /// <summary>Current access rules version</summary>
        string ProfileAccessRulesVersion { get; set; }
        /// <summary>Name of the resource</summary>
        string ProfileName { get; set; }
        /// <summary>List of Provisioning Issues if any</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.IProvisioningIssue> ProvisioningIssue { get; set; }
        /// <summary>Provisioning state of NetworkSecurityPerimeter configuration propagation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("Unknown", "Creating", "Updating", "Accepted", "InvalidResponse", "Succeeded", "SucceededWithIssues", "Failed", "Deleting", "Deleted", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Information about resource association</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeterConfigurationPropertiesResourceAssociation ResourceAssociation { get; set; }
        /// <summary>Access Mode of the resource association</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventHub.PSArgumentCompleterAttribute("NoAssociationMode", "EnforcedMode", "LearningMode", "AuditMode", "UnspecifiedMode")]
        string ResourceAssociationAccessMode { get; set; }
        /// <summary>Name of the resource association</summary>
        string ResourceAssociationName { get; set; }
        /// <summary>ARM Id of source resource</summary>
        string SourceResourceId { get; set; }

    }
}