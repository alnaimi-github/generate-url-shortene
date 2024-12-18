# Generate-url-shortene

## Let's Build It: Url Shortener Project

## Infrastructure as Code

### Log in  into Azure

```bash
az login 
```

### Create Resource Group

```bash
az group create --name rg-urlshortener-dev --location EastAsia
```

### Create User for GH Actions

```bash
az ad sp create-for-rbac --name "Github-Actions-SP" \
                         --role contributor \
                         --scopes /subscriptions/c49b5a4a-e3a7-175b-b6e3-14dbafe20ebd \
                         --sdk-auth
                         
```

```powershell
az ad sp create-for-rbac --name "Github-Actions-SP" `
                         --role contributor `
                         --scopes /subscriptions/c39b5a5a-e3a7-495b-b6e3-84dbafe30ebd `
                         --sdk-auth
```

### Generate-Secret-Dev-App

```bash
az webapp deployment list-publishing-profiles --name api-x33hej6wd7mbu --resource-group rg-urlshortener-dev --xml

```
