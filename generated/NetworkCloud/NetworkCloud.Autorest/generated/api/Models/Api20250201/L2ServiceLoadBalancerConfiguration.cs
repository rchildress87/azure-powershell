// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// L2ServiceLoadBalancerConfiguration represents the configuration of a layer 2 service load balancer.
    /// </summary>
    public partial class L2ServiceLoadBalancerConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IL2ServiceLoadBalancerConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IL2ServiceLoadBalancerConfigurationInternal
    {

        /// <summary>Backing field for <see cref="IPAddressPool" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IIPAddressPool[] _iPAddressPool;

        /// <summary>
        /// The list of pools of IP addresses that can be allocated to load balancer services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IIPAddressPool[] IPAddressPool { get => this._iPAddressPool; set => this._iPAddressPool = value; }

        /// <summary>Creates an new <see cref="L2ServiceLoadBalancerConfiguration" /> instance.</summary>
        public L2ServiceLoadBalancerConfiguration()
        {

        }
    }
    /// L2ServiceLoadBalancerConfiguration represents the configuration of a layer 2 service load balancer.
    public partial interface IL2ServiceLoadBalancerConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The list of pools of IP addresses that can be allocated to load balancer services.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of pools of IP addresses that can be allocated to load balancer services.",
        SerializedName = @"ipAddressPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IIPAddressPool) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IIPAddressPool[] IPAddressPool { get; set; }

    }
    /// L2ServiceLoadBalancerConfiguration represents the configuration of a layer 2 service load balancer.
    internal partial interface IL2ServiceLoadBalancerConfigurationInternal

    {
        /// <summary>
        /// The list of pools of IP addresses that can be allocated to load balancer services.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IIPAddressPool[] IPAddressPool { get; set; }

    }
}