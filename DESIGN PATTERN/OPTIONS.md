### Option Pattern 
- The .NET Core Options pattern is a way of configuring an application using classes and objects in the form of options. This pattern is commonly used to provide configuration settings to an application, which can be used to customize its behavior.
- *The Options pattern consists of the following components:*
1. Options class: This class is used to define the configuration settings required by the application. It should have properties with default values that can be overridden by configuration providers.
2. Configuration provider: This is used to provide configuration values to the application. It can be any source of configuration data, such as environment variables, JSON files, command-line arguments, or Azure Key Vault.
3. Configuration builder: This is used to build the configuration providers and define the order in which they should be applied.
4. Service registration: This is used to register the Options class with the dependency injection container, allowing it to be injected into the application's services.