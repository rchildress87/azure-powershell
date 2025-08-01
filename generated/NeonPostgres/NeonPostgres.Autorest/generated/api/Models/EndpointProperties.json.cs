// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Properties specific to Endpoints</summary>
    public partial class EndpointProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject into a new instance of <see cref="EndpointProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal EndpointProperties(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_entityId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString>("entityId"), out var __jsonEntityId) ? (string)__jsonEntityId : (string)_entityId;}
            {_entityName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString>("entityName"), out var __jsonEntityName) ? (string)__jsonEntityName : (string)_entityName;}
            {_createdAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString>("createdAt"), out var __jsonCreatedAt) ? (string)__jsonCreatedAt : (string)_createdAt;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_attribute = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonArray>("attributes"), out var __jsonAttributes) ? If( __jsonAttributes as Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes) (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.Attributes.FromJson(__u) )) ))() : null : _attribute;}
            {_projectId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString>("projectId"), out var __jsonProjectId) ? (string)__jsonProjectId : (string)_projectId;}
            {_branchId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString>("branchId"), out var __jsonBranchId) ? (string)__jsonBranchId : (string)_branchId;}
            {_endpointType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString>("endpointType"), out var __jsonEndpointType) ? (string)__jsonEndpointType : (string)_endpointType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IEndpointProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IEndpointProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IEndpointProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject json ? new EndpointProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="EndpointProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="EndpointProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._entityId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString(this._entityId.ToString()) : null, "entityId" ,container.Add );
            }
            AddIf( null != (((object)this._entityName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString(this._entityName.ToString()) : null, "entityName" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._createdAt)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString(this._createdAt.ToString()) : null, "createdAt" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (null != this._attribute)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.XNodeArray();
                foreach( var __x in this._attribute )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("attributes",__w);
            }
            AddIf( null != (((object)this._projectId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString(this._projectId.ToString()) : null, "projectId" ,container.Add );
            AddIf( null != (((object)this._branchId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString(this._branchId.ToString()) : null, "branchId" ,container.Add );
            AddIf( null != (((object)this._endpointType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString(this._endpointType.ToString()) : null, "endpointType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}