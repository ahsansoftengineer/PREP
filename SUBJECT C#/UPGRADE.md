How to Upgrade .Net Projects?
```bash
dotnet tool install -g upgrade-assistant
dotnet tool update -g upgrade-assistant
dotnet tool install -g --ignore-failed-sources upgrade-assistant
upgrade-assistant upgrade

# Upgrading Individual Package
dotnet add package System.IdentityModel.Tokens.Jwt --version 7.6.2
```