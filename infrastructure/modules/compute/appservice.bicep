param location string = resourceGroup().location
param appServiceplanName string
param appName string

resource appServicePlan 'Microsoft.Web/serverfarms@2023-12-01' = {
  name: appServiceplanName
  location: location
  kind: 'linux'
  sku: {
    name: 'B1'
  }
  properties: {
    reserved: true
  }
}


resource webApp 'Microsoft.Web/sites@2023-12-01' = {
  name: appName
  location: location
  properties: {
    serverFarmId: appServicePlan.id
    httpsOnly: true
    siteConfig: {
      linuxFxVersion: 'DOTNETCORE|9.0'
    }
  }
}


resource webAppConfig 'Microsoft.Web/sites/config@2023-12-01' = {
  parent: webApp
  name: 'web'
  properties: {
 scmType: 'GitHub'
  }
}

output webAppId string = webApp.id
