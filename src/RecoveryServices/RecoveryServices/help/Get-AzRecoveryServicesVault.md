---
external help file: Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.dll-Help.xml
Module Name: Az.RecoveryServices
ms.assetid: 818B5302-91EE-425F-B1CD-86B626F1B7A3
online version: https://learn.microsoft.com/powershell/module/az.recoveryservices/get-azrecoveryservicesvault
schema: 2.0.0
---

# Get-AzRecoveryServicesVault

## SYNOPSIS

Gets a list of Recovery Services vaults.

## SYNTAX

### ByTagNameValueParameterSet
```
Get-AzRecoveryServicesVault [[-ResourceGroupName] <String>] [[-Name] <String>] [-TagName <String>]
 [-TagValue <String>] [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

### ByTagObjectParameterSet
```
Get-AzRecoveryServicesVault [[-ResourceGroupName] <String>] [[-Name] <String>] -Tag <Hashtable>
 [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

## DESCRIPTION

The **Get-AzRecoveryServicesVault** cmdlet gets a list of Recovery Services vaults in the current subscription.

## EXAMPLES

### Example 1

```powershell
Get-AzRecoveryServicesVault
```

Get the list of vault in selected subscription.

### Example 2

```powershell
Get-AzRecoveryServicesVault -ResourceGroupName "resourceGroup"
```

Get the list of vault in resource group in selected subscription.

### Example 3: Get vault MSI, PublicNetworkAccess, ImmutabilityState, CrossSubscriptionRestoreState

```powershell
$vault = Get-AzRecoveryServicesVault -ResourceGroupName "resourceGroup" -Name "vaultName"
$vault.Identity | Format-List
$vault.Properties.PublicNetworkAccess
$vault.Properties.ImmutabilitySettings.ImmutabilityState
$vault.Properties.RestoreSettings.CrossSubscriptionRestoreSettings.CrossSubscriptionRestoreState
```

```output
PrincipalId : XXXXXXXX-XXXX-XXXX
TenantId    : XXXXXXXX-XXXX-XXXX
Type        : SystemAssigned

Enabled
Disabled
Enabled
```

The first cmdlet gets the vault in resource group with given name. Then we access the MSI information from the vault. Third and fourth commands are used to fetch the public network access, immutability state, cross subscription restore state of the vault.

### Example 4: Get Encryption properties of the vault

```powershell
$vault = Get-AzRecoveryServicesVault -ResourceGroupName "resourceGroup" -Name "vaultName"

$vault.Properties.EncryptionProperty.KeyVaultProperties
$vault.Properties.EncryptionProperty.KekIdentity
$vault.Properties.EncryptionProperty.InfrastructureEncryption
```

```output
KeyUri
------
https://oss-pstest-keyvault.vault.azure.net/keys/cmk-pstest-key2

UseSystemAssignedIdentity UserAssignedIdentity
------------------------- --------------------
                    False /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourcegroups/resourceGroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/pstest-uami

Enabled
```

The first cmdlet gets the vault in resource group with given name. The second, third and fourth commands are used to fetch the encryption properties (KeyUri, KekIdentity and infrastructure encryption) of the vault for CMK.

## PARAMETERS

### -DefaultProfile

The credentials, account, tenant, and subscription used for communication with azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name

Specifies the name of the vault to query for.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName

Specifies the name of the Azure resource group from which to retrieve the specified Recovery Services object.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag

Specifies the Tags to query for

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ByTagObjectParameterSet
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TagName

Specifies the Key of the Tag to query for

```yaml
Type: System.String
Parameter Sets: ByTagNameValueParameterSet
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TagValue

Specifies the Value of the Tag to query for

```yaml
Type: System.String
Parameter Sets: ByTagNameValueParameterSet
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.Commands.RecoveryServices.ARSVault

## NOTES
Get-AzRecoveryServicesVault in old version of Az.RecoveryServices(<=2.10.0) cannot work with Az.Accounts(>=1.8.1) because of incorrect assembly reference. The module Az.RecoveryServices needs to be upgraded to 2.11.0 or newer if you are using the latest Az or Az.Accounts.

## RELATED LINKS

[Get-AzRecoveryServicesVaultSettingsFile](./Get-AzRecoveryServicesVaultSettingsFile.md)

[New-AzRecoveryServicesVault](./New-AzRecoveryServicesVault.md)

[Remove-AzRecoveryServicesVault](./Remove-AzRecoveryServicesVault.md)
