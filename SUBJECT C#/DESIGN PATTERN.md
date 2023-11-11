In .NET Core, as well as in other software development environments, various design patterns are commonly used to solve recurring problems and promote best practices in software architecture. Here are some design patterns that are commonly applied in .NET Core development:

1. **Dependency Injection (DI):**
   - **Description:** Provides a way to create loosely coupled components by injecting dependencies into a class instead of having the class create its dependencies.
   - **Usage in .NET Core:** .NET Core has built-in support for DI through the `Microsoft.Extensions.DependencyInjection` framework.

2. **Factory Method:**
   - **Description:** Defines an interface for creating an object but leaves the choice of its type to the subclasses, creating an instance of one of several possible classes.
   - **Usage in .NET Core:** Often used in combination with DI to create objects with dependencies.

3. **Singleton:**
   - **Description:** Ensures that a class has only one instance and provides a global point of access to it.
   - **Usage in .NET Core:** Often applied when a single instance of a service or configuration is required across the application.

4. **Repository:**
   - **Description:** Mediates between the domain and data mapping layers, acting like an in-memory collection of domain objects.
   - **Usage in .NET Core:** Frequently used to abstract data access logic and provide a clean separation between the application and data storage.

5. **Builder:**
   - **Description:** Separates the construction of a complex object from its representation, allowing the same construction process to create different representations.
   - **Usage in .NET Core:** Applied in scenarios where you need to create complex objects with various configurations.

6. **Strategy:**
   - **Description:** Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
   - **Usage in .NET Core:** Useful when you want to define a family of algorithms and make them interchangeable based on specific requirements.

7. **Observer:**
   - **Description:** Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
   - **Usage in .NET Core:** Applied in event-driven scenarios where one part of the system needs to be notified when the state of another part changes.

8. **Command:**
   - **Description:** Encapsulates a request as an object, thereby allowing for parameterization of clients with different requests, queuing of requests, and logging of the parameters of a request.
   - **Usage in .NET Core:** Commonly used to implement undo/redo functionality, or in scenarios where you need to decouple sender and receiver of a request.

9. **Decorator:**
   - **Description:** Attaches additional responsibilities to an object dynamically, providing a flexible alternative to subclassing for extending functionality.
   - **Usage in .NET Core:** Used for adding or modifying behavior of classes without altering their code.

10. **Chain of Responsibility:**
    - **Description:** Passes the request along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.
    - **Usage in .NET Core:** Often used in scenarios where multiple objects in a chain have the opportunity to handle a request.

These are just a few examples of design patterns commonly used in .NET Core development. The choice of pattern often depends on the specific problem you are trying to solve and the desired software architecture.