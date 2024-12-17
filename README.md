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
                         --scopes /subscriptions/c49b5a1a-e3a7-485b-b6e3-84dbafe30ebd \
                         --sdk-auth
                         
```

```powershell
az ad sp create-for-rbac --name "Github-Actions-SP" `
                         --role contributor `
                         --scopes /subscriptions/c49b5a1a-e3a7-485b-b6e3-84dbafe30ebd `
                         --sdk-auth
```
