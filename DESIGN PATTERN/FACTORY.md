### Where does Dotnet Core itself using Factory Pattern?
The .NET Core framework itself, as of my last knowledge update in January 2022, utilizes various design patterns, including the Factory Pattern, in different areas. However, keep in mind that the framework is vast and evolves over time, so there may be changes or additions to the use of design patterns.

Here are a few examples where you might find the Factory Pattern being used within the .NET Core framework:

1. **Data Access:**
   - In the Entity Framework (EF) Core, the `DbContext` acts as a factory for creating database contexts. When you create an instance of `DbContext`, it effectively acts as a factory for creating instances of your entity classes and managing database connections.

2. **Logging:**
   - The `ILoggerFactory` in the Microsoft.Extensions.Logging namespace is a factory interface for creating instances of `ILogger`. Different logging providers, such as Console, Debug, or third-party providers, implement this factory pattern to produce loggers.

```csharp
// Example of ILoggerFactory usage in a .NET Core application
public class SomeService
{
    private readonly ILogger _logger;

    public SomeService(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<SomeService>();
    }

    public void DoSomething()
    {
        _logger.LogInformation("Doing something...");
    }
}
```

3. **Dependency Injection:**
   - The .NET Core framework's built-in Dependency Injection container (`IServiceProvider` and related classes) can be considered a form of a factory. It's responsible for creating instances of services and managing their lifetimes.

```csharp
// Example of dependency injection in a .NET Core application
public class SomeController : Controller
{
    private readonly ISomeService _someService;

    public SomeController(ISomeService someService)
    {
        _someService = someService;
    }

    // ...
}
```

These are just a few examples, and the use of the Factory Pattern can be found in various other parts of the framework. Keep in mind that the specific implementation details and design patterns used within the framework might evolve over time with new releases and updates. Always refer to the official documentation and source code for the most accurate and up-to-date information.

### Factory Pattern Example
- In C#, the Factory Design Pattern can be implemented using interfaces, abstract classes, and concrete classes. Here's a simple example to illustrate the Factory Pattern:

```csharp
using System;

// Product interface
interface IProduct
{
    void Display();
}

// ConcreteProduct classes
class ConcreteProductA : IProduct
{
    public void Display()
    {
        Console.WriteLine("Concrete Product A");
    }
}

class ConcreteProductB : IProduct
{
    public void Display()
    {
        Console.WriteLine("Concrete Product B");
    }
}

// Creator interface (or abstract class)
interface ICreator
{
    IProduct CreateProduct();
}

// ConcreteCreator classes
class ConcreteCreatorA : ICreator
{
    public IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}

class ConcreteCreatorB : ICreator
{
    public IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}

// Client code
class Program
{
    static void Main()
    {
        // Using ConcreteCreatorA
        ICreator creatorA = new ConcreteCreatorA();
        IProduct productA = creatorA.CreateProduct();
        productA.Display();

        // Using ConcreteCreatorB
        ICreator creatorB = new ConcreteCreatorB();
        IProduct productB = creatorB.CreateProduct();
        productB.Display();
    }
}
```

In this example:
- `IProduct` is the interface representing the product that concrete product classes (`ConcreteProductA` and `ConcreteProductB`) implement.
- `ICreator` is the interface representing the creator (factory) that concrete creator classes (`ConcreteCreatorA` and `ConcreteCreatorB`) implement.
- `ConcreteProductA` and `ConcreteProductB` are the concrete product classes.
- `ConcreteCreatorA` and `ConcreteCreatorB` are the concrete creator classes that implement the factory method `CreateProduct()`.

The client code (`Program` class) uses the concrete creator classes to create instances of products without knowing their specific types. This demonstrates the flexibility of the Factory Pattern by allowing easy extension to new product types without modifying the client code.

This is a basic example, and in a real-world scenario, the factory method might take parameters or perform more complex logic for object creation. Additionally, you might encounter scenarios where you need to use dependency injection or IoC containers for managing object creation.