In .NET Core, you can save configuration settings in different resources or configuration sources, depending on your application's needs. The configuration system is highly flexible and allows you to use various sources to manage your settings. Here are some common resources where you can save configuration settings:

1. **appsettings.json File**:
   - You can use the `appsettings.json` file to store general configuration settings. You can have different versions of this file for different environments (e.g., `appsettings.Development.json`, `appsettings.Production.json) and override settings as needed.

2. **Environment Variables**:
   - Environment variables provide a way to set configuration values at the system level. You can access these variables in your application's configuration.

3. **User Secrets**:
   - User Secrets is a secure way to store sensitive data like API keys during development. It is stored in a JSON file outside your project's source code.

4. **Command-Line Arguments**:
   - You can pass configuration settings as command-line arguments when running your application. These settings can be accessed programmatically.

5. **Custom Configuration Sources**:
   - You can create custom configuration sources to load settings from various places, such as databases, key vaults, external services, and more. You need to implement the necessary logic to retrieve the settings.

6. **Azure Key Vault**:
   - Azure Key Vault is a cloud-based service that securely stores secrets, keys, and certificates. .NET Core applications can access configuration settings stored in Azure Key Vault.

7. **Docker Configurations**:
   - If you're using Docker for containerized applications, you can pass environment variables or configuration files to containers during runtime.

8. **Database Storage**:
   - You can store configuration settings in a database, and your application can read these settings from the database during startup.

9. **Configuration Services**:
   - You can use configuration services to fetch configuration settings from remote configuration servers like Consul, etcd, or Spring Cloud Config.

Here's an example of how to access configuration settings in a .NET Core application:

```csharp
using Microsoft.Extensions.Configuration;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        string apiKey = Configuration["AppSettings:ApiKey"];
        // Use apiKey in your application
    }
}
```

The configuration settings are typically defined in the respective sources and loaded into the `IConfiguration` object, which you can access in your application's code as needed. The choice of resource depends on your application's requirements, security considerations, and deployment environment.