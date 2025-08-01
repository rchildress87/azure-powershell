<!-- region Generated -->
# Az.Migrate
This directory contains the PowerShell module for the Migrate service.

---
## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.7.5 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.Migrate`, see [how-to.md](how-to.md).
<!-- endregion -->

---
## Generation Requirements
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br>`npm install -g autorest@beta`<br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g pwsh`<br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g dotnet-sdk-2.2`<br>&nbsp;

## Run Generation
In this directory, run AutoRest:
> `autorest`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
skip-semantics-validation: true
commit: 473d98be4cc2fb14db8bddbba8d3184d0aa49636
require:
  - $(this-folder)/../../readme.azure.noprofile.md
input-file:
  - $(repo)/specification/migrate/resource-manager/Microsoft.OffAzure/stable/2020-01-01/migrate.json
  - $(repo)/specification/migrateprojects/resource-manager/Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
  - $(repo)/specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2024-01-01/service.json
  - $(repo)/specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json

module-version: 3.0.12
title: Migrate 
subject-prefix: 'Migrate'

use-extension:
  "@autorest/powershell": "3.x"

directive:
  # Correct some swagger operationIds
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where: $.paths..operationId
    transform: return $.replace(/^(.*)_GetAll(.*)$/g, "$1_List")
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where: $.paths..operationId
    transform: return $.replace(/^(.*)_Get(.*)$/g, "$1_Get")
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where: $.paths..operationId
    transform: return $.replace(/^(.*)_Put(.*)$/g, "$1_CreateOrUpdate")
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where: $.paths..operationId
    transform: return $.replace(/^(.*)_Patch(.*)$/g, "$1_Update")
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where: $.paths..operationId
    transform: return $.replace(/^(.*)_Refresh(.*)$/g, "$1_Refresh")
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where: $
    transform: return $.replace(/IEdm/g, "Iedm")
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where: $
    transform: return $.replace(/IServiceProvider/g, "IserviceProvider")
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where: $.paths..operationId
    transform: return $.replace(/^(.*)_Enumerate(.*)$/g, "$1_List")
  # Correct some generated models
  - no-inline:
    - TestMigrateProviderSpecificInput
    - MigrationProviderSpecificSettings
    - MigrateProviderSpecificInput
    - ResyncProviderSpecificInput
    - EnableMigrationProviderSpecificInput
    - ResumeReplicationProviderSpecificInput
    - UpdateMigrationItemProviderSpecificInput
    - IedmStructuredType
    - IedmNavigationProperty
    - PolicyProviderSpecificInput
    - ReplicationProviderSpecificContainerMappingInput
    - ProtectionContainerMappingProviderSpecificDetails
    - MigrateProjectProperties
    - FabricProperties
    - FabricModelProperties
    - FabricModelCustomProperties
    - AzStackHCIFabricModelCustomProperties
    - HyperVMigrateFabricModelCustomProperties
    - VMwareMigrateFabricModelCustomProperties
    - PolicyModelProperties
    - ReplicationExtensionModelProperties
    - ProtectedItemModelProperties
    - ProtectedItemModelCustomProperties
    - HyperVToAzStackHCIProtectedItemModelCustomProperties
    - VMwareToAzStackHCIProtectedItemModelCustomProperties
    - ProtectedItemModelPropertiesUpdate
    - ProtectedItemModelCustomPropertiesUpdate
    - HyperVToAzStackHCIProtectedItemModelCustomPropertiesUpdate
    - VMwareToAzStackHCIProtectedItemModelCustomPropertiesUpdate
    - PlannedFailoverModelProperties
    - JobModelProperties
    - JobModelCustomProperties
    - TaskModel
    - TaskModelCustomProperties
    - FabricAgentModelProperties
    - FabricAgentModelCustomProperties
    - VaultModelProperties
  # Remove variants not in scope
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Test$
      subject: ^ReplicationMigrationItemMigrate
      variant: ^TestViaIdentity$|^TestViaIdentityExpanded$|^Test$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Get$
      subject: ReplicationFabric$|ReplicationPolicy$|ReplicationProtectionContainer$|ReplicationMigrationItem$|ReplicationJob$|ReplicationProtectionContainerMapping$|ReplicationRecoveryServicesProvider$
      variant: ^GetViaIdentity$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Remove$
      subject: ^ReplicationMigrationItem
      variant: ^DeleteViaIdentity$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Move$
      subject: ^ReplicationMigrationItem
      variant: ^MigrateViaIdentityExpanded$|^Migrate$|^MigrateViaIdentity$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Suspend$
      subject: ^ReplicationMigrationItemReplication
      variant: ^PauseViaIdentityExpanded$|^Pause$|^PauseViaIdentity$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Resume$
      subject: ^ReplicationMigrationItemReplication
      variant: ^ResumeViaIdentityExpanded$|^Resume$|^ResumeViaIdentity$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Invoke$
      subject: ^ResyncReplicationMigrationItem
      variant: ^ResyncViaIdentityExpanded$|^ResyncViaIdentity$|^Resync$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: New$
      subject: ^ReplicationMigrationItem|ReplicationProtectionContainerMapping$|ReplicationPolicy$
      variant: ^CreateViaIdentity$|^CreateViaIdentityExpanded$|^Create$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Update$
      subject: ^ReplicationMigrationItem
      variant: ^UpdateViaIdentityExpanded$|^UpdateViaIdentity$|^Update$
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Get$
      subject: ^Machine
      variant: ^Get1$|^GetViaIdentity1|^List1
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Get$
      subject: ^Site
      variant: ^Get1$|^GetViaIdentity1|^Get2$|^GetViaIdentity2
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Get$
      subject: Site$|Machine$|RunAsAccount$
      variant: ^GetViaIdentity$
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Set$
      subject: Project$
      variant: ^Put$|^PutViaIdentity|^PutViaIdentityExpanded
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Register$
      subject: ProjectTool$
      variant: ^Register$|^RegisterViaIdentity|^RegisterViaIdentityExpanded
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Get$
      subject: Project$|Solution$
      variant: ^GetViaIdentity$
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Get$
      subject: Solution$
      variant: ^List$
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Remove$
      subject: Project$
      variant: ^DeleteViaIdentity$
    remove: true
  # Remove cmdlets not in scope
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Update$|Start$|Stop$
      subject: ^Machine
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Set$|Remove$|New$
      subject: ^VCenter$
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: New$|Remove$|Update$
      subject: ^Site
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      subject: ^VMwareOperationsStatus
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      subject: ^Database|^DatabaseInstance|^SolutionConfig|^Event
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Invoke$
      subject: CleanupSolutionData$
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Set$|Remove$|Update$
      subject: ProjectSummary$
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Remove$|Update$
      subject: ^Solution
    remove: true
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Update$
      subject: Project$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      subject: ^ReplicationRecoveryPlan|ReplicationRecoveryServiceProvider$|ReplicationEvent$|ReplicationAlertSetting$|ReplicationLogicalNetwork$|^ReplicationProtectedItem|^ReplicationNetwork|^ReplicationStorage|RecoveryPoint$|ProtectableItem$|FabricGateway$|FabricToAad$|ReplicationvCenter$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Export$|Find$|Switch$|Clear$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      subject: ^Commit|^Renew|^Reprotect|^Unplanned|VaultHealth$|ComputeSize$|FabricConsistency$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: New$|Remove$
      subject: Fabric$|ProtectionContainer$|ReplicationRecoveryServicesProvider$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Remove$
      subject: ReplicationPolicy$|ReplicationProtectionContainerMapping$|ReplicationFabricInfra$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Update$
      subject: Fabric$|Policy$|ProtectionContainer$|ReplicationProtectionContainerMapping$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Stop$|Resume$|Restart$
      subject: Job$
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Get
      subject: ^ReplicationAppliance|^ReplicationEligibilityResult|^ReplicationProtectionIntent
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Get
      subject: ^ReplicationVaultSetting|^SupportedOperatingSystem|^ReplicationProtectionIntent
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: New
      subject: ^ReplicationVaultSetting|^SupportedOperatingSystem|^ReplicationProtectionIntent
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Get
      subject: ^HyperV(Cluster|Host|Job|OperationsStatus)$
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Set
      subject: ^HyperV(Cluster|Host)$
    remove: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: New|Remove|Update
      subject: ^HyperV
    remove: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: Test|Invoke
      subject: NameAvailability$|DeploymentPreflight
    remove: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: Get|New
      subject: ^EmailConfiguration
    remove: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: Get
      subject: ^(FabricAgent|ProtectedItem|Vault|Job)OperationStatus$
    remove: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: Get
      subject: ^FabricOperationsStatus$
    remove: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: New
      subject: ^(FabricAgent|Vault)
    remove: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: Update
      subject: ^Vault
    remove: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      subject: PrivateEndpointConnection|PrivateLinkResource
    remove: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      subject: OperationResult
    remove: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Invoke
      subject: ^PlannedReplication
    remove: true
  # Rename cmdlets for Azure Local
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: Get
      subject: ^Fabric$
    set:
      subject: LocalReplicationFabric
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: Get
      subject: ^Job$
    set:
      subject: LocalReplicationJob      
  # Hide cmdlets used by custom
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Set$
      subject: ^Solution
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Get$
      subject: ToAzureMigrate$
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Get$
      subject: ReplicationMigrationItem$|ReplicationJob$
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Test$
      subject: ^ReplicationMigrationItemMigrate
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: New$|Remove$
      subject: ^ReplicationMigrationItem
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Move$
      subject: ^ReplicationMigrationItem
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Restart$
      subject: ^ReplicationJob
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Invoke$
      subject: ^ResyncReplicationMigrationItem
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Update$
      subject: ^ReplicationMigrationItem
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Suspend$
      subject: ^ReplicationMigrationItemReplication
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      verb: Resume$
      subject: ^ReplicationMigrationItemReplication
    hide: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      subject: ^Planned
    hide: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Get
      subject: ^HyperV(Site|RunAsAccount)$
    hide: true
  # Hide cmdlets not to be visible to user.
  - from: Microsoft.Migrate/preview/2018-09-01-preview/migrate.json
    where:
      verb: Set$
      subject: Project$
    hide: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Set$
      subject: (HyperV)?Site$
    hide: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Get$|List$
      subject: Machine$
    hide: true
  - from: Microsoft.OffAzure/stable/2020-01-01/migrate.json
    where:
      verb: Get$
      subject: ^VCenter$
    hide: true
  - where:
      verb: New$|Update$
      variant: ^(Update|Create)(?!.*?Expanded)
    hide: true
  - where:
      verb: New$
      variant: ^CreateViaIdentity
    hide: true
  - from: Microsoft.DataReplication/stable/2024-09-01/recoveryservicesdatareplication.json
    where:
      verb: Get$|Invoke$|New$|Remove$|Test$|Update$
      subject: ^FabricAgent|^Fabric|^Policy|^EmailConfiguration|^ProtectedItem|^ReplicationExtension|^Vault
    hide: true
  - where:
      verb: New$|Set$|Update$
      subject: Site$|VCenter$
      parameter-name: Name
    clear-alias: true
  # Table output formatting
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      model-name: MigrationItem
    set:
      suppress-format: true 
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      model-name: Job
    set:
      suppress-format: true
  - from: Microsoft.RecoveryServices/stable/2024-01-01/service.json
    where:
      model-name: Fabric
    set:
      suppress-format: true
