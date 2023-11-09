Entity Framework Core (EF Core) is a popular Object-Relational Mapping (ORM) framework for .NET applications. It incorporates several design patterns and principles to provide a flexible and efficient way to work with databases. Some of the key design patterns and principles that are used in EF Core include:

1. Repository Pattern: EF Core encourages the use of the repository pattern to abstract database access. Developers can create repositories that provide a higher-level interface for data access, making it easier to work with database entities.

2. Unit of Work Pattern: EF Core incorporates the unit of work pattern to manage the lifecycle of database transactions. It allows you to group a set of operations into a single unit of work, ensuring that they are all committed or rolled back together.

3. Entity-Relationship Mapping (ERM): EF Core is built on the concept of mapping database entities to object-oriented entities. It uses the ERM pattern to define how database tables and their relationships are translated into classes and associations in your application.

4. Lazy Loading: EF Core supports lazy loading, a design pattern that defers the loading of related entities until they are accessed. This can help improve performance by loading only the data that is actually needed.

5. Identity Map Pattern: EF Core employs the identity map pattern to ensure that each entity is represented by a single instance within the context. This helps prevent issues related to duplicate entities and ensures that changes to an entity are consistently tracked.

6. Dependency Injection: EF Core is designed to work seamlessly with dependency injection containers, making it easy to inject database contexts and repositories into your application components. This promotes a more modular and testable design.

7. Fluent API: EF Core provides a fluent API that allows developers to configure entity relationships, mappings, and other aspects of the model using method chaining. This follows the Fluent Interface pattern, making it more readable and maintainable.

8. Query Object Pattern: EF Core allows you to build complex database queries using a LINQ-like syntax, which can be seen as an implementation of the Query Object pattern. This makes it easier to construct and compose queries in a type-safe manner.

While these design patterns and principles are used in EF Core, it's important to note that EF Core is a complex framework that incorporates various patterns and techniques to achieve its goals. The specific patterns and principles used may vary depending on how you use the framework in your application.