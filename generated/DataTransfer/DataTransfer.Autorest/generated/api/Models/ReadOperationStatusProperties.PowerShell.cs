// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace ADT.Models
{
    using ADT.Runtime.PowerShell;

    /// <summary>Operation status associated with the last patch request</summary>
    [System.ComponentModel.TypeConverter(typeof(ReadOperationStatusPropertiesTypeConverter))]
    public partial class ReadOperationStatusProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="ADT.Models.ReadOperationStatusProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="ADT.Models.IReadOperationStatusProperties" />.</returns>
        public static ADT.Models.IReadOperationStatusProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReadOperationStatusProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="ADT.Models.ReadOperationStatusProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="ADT.Models.IReadOperationStatusProperties" />.</returns>
        public static ADT.Models.IReadOperationStatusProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReadOperationStatusProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReadOperationStatusProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ReadOperationStatusProperties" /> model class.</returns>
        public static ADT.Models.IReadOperationStatusProperties FromJsonString(string jsonText) => FromJson(ADT.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="ADT.Models.ReadOperationStatusProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReadOperationStatusProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Status"))
            {
                ((ADT.Models.IReadOperationStatusPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((ADT.Models.IReadOperationStatusPropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((ADT.Models.IReadOperationStatusPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((ADT.Models.IReadOperationStatusPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((ADT.Models.IReadOperationStatusPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((ADT.Models.IReadOperationStatusPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="ADT.Models.ReadOperationStatusProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReadOperationStatusProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Status"))
            {
                ((ADT.Models.IReadOperationStatusPropertiesInternal)this).Status = (string) content.GetValueForProperty("Status",((ADT.Models.IReadOperationStatusPropertiesInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((ADT.Models.IReadOperationStatusPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((ADT.Models.IReadOperationStatusPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((ADT.Models.IReadOperationStatusPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((ADT.Models.IReadOperationStatusPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, ADT.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Operation status associated with the last patch request
    [System.ComponentModel.TypeConverter(typeof(ReadOperationStatusPropertiesTypeConverter))]
    public partial interface IReadOperationStatusProperties

    {

    }
}