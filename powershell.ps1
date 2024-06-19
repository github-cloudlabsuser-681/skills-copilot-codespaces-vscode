# Variables
$resourceGroupName = "example-resources"
$location = "East US"
$storageAccountName = "examplestoracc"
$storageSkuName = "Standard_LRS"
$storageKind = "StorageV2"
$enableHttpsTrafficOnly = $true

# Create a resource group
New-AzResourceGroup -Name $resourceGroupName -Location $location

# Create a storage account
New-AzStorageAccount -Name $storageAccountName `
                     -ResourceGroupName $resourceGroupName `
                     -Location $location `
                     -SkuName $storageSkuName `
                     -Kind $storageKind `
                     -EnableHttpsTrafficOnly $enableHttpsTrafficOnly