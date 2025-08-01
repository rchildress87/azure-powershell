// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class AzureSqlDatabaseManagedInstanceMsiScanPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlDatabaseManagedInstanceMsiScanPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlDatabaseManagedInstanceMsiScanPropertiesAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlDatabaseManagedInstanceMsiScanProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlDatabaseManagedInstanceMsiScanProperties __azureSqlDatabaseManagedInstanceMsiScanProperties = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AzureSqlDatabaseManagedInstanceMsiScanProperties();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesCollection Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).Collection = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CollectionLastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CollectionReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CollectionReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CollectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CollectionType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesConnectedVia ConnectedVia { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ConnectedVia; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ConnectedVia = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ConnectedViaReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ConnectedViaReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ConnectedViaReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CreatedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string DatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).DatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).DatabaseName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).LastModifiedAt; }

        /// <summary>Internal Acessors for Collection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesCollection Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).Collection = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CollectionLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CollectionLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CollectionLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ConnectedVia</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesConnectedVia Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.ConnectedVia { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ConnectedVia; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ConnectedVia = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).LastModifiedAt = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ScanRulesetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ScanRulesetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ScanRulesetName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ScanRulesetType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ScanRulesetType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ScanRulesetType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ServerEndpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ServerEndpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).ServerEndpoint = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public int? Worker { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).Worker; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__azureSqlDatabaseManagedInstanceMsiScanProperties).Worker = value ?? default(int); }

        /// <summary>
        /// Creates an new <see cref="AzureSqlDatabaseManagedInstanceMsiScanPropertiesAutoGenerated" /> instance.
        /// </summary>
        public AzureSqlDatabaseManagedInstanceMsiScanPropertiesAutoGenerated()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureSqlDatabaseManagedInstanceMsiScanProperties), __azureSqlDatabaseManagedInstanceMsiScanProperties);
            await eventListener.AssertObjectIsValid(nameof(__azureSqlDatabaseManagedInstanceMsiScanProperties), __azureSqlDatabaseManagedInstanceMsiScanProperties);
        }
    }
    public partial interface IAzureSqlDatabaseManagedInstanceMsiScanPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlDatabaseManagedInstanceMsiScanProperties
    {

    }
    internal partial interface IAzureSqlDatabaseManagedInstanceMsiScanPropertiesAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAzureSqlDatabaseManagedInstanceMsiScanPropertiesInternal
    {

    }
}