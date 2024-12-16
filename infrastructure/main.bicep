param location string = resourceGroup().location

var uniqueId = uniqueString(resourceGroup().id)

module apiService 'modules/compute/appservice.bicep'= {
  name: 'apiDeployment'
  params: {
    location: location
    appName: 'api-${uniqueId}'
    appServiceplanName: 'plan-api-${uniqueId}'
  }
}



