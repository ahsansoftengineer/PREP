


### DEPENDENCY INJECTION
### What is Service LifeTimes?
1. Transient -> Create each time they are requested from the service container,
2. Scoped -> Created Once per client request (connection)
3. Singleton -> Created at the first time they are requested (or when Startup.ConfigureServices is run and an instance is specified with the service registration). Every subsequent request uses the same instance. If the app requires singleton behaviour, allowing the service container to manage the service's lifetime is recommended. Don't implement the singleton design pattern and provide user code to manage the object's lifetime in the class.
### DI LifeTime Dotnet Core API
#### First Request Chrome
-------------xxx-----------
From DependencyService1
- Transient - 4a3256f2-b319-4d64-bbc3-856d4eefe38e // Every Step New
- Scoped - 31764c5c-c8df-471f-9b61-06085a3d2f0d // Each for Request
- Singleton - 93fefd73-db11-4713-a305-e0a5468f522e // Same for every Request
- Singleton Instance - 00000000-0000-0000-0000-000000000000 // // Same for every Request

-------------xxx-----------
From DependencyService2
- Transient - 9e52b78c-a178-458c-a1b2-df9c48f3dcf6
- Scoped - 31764c5c-c8df-471f-9b61-06085a3d2f0d
- Singleton - 93fefd73-db11-4713-a305-e0a5468f522e
- Singleton Instance - 00000000-0000-0000-0000-000000000000

#### Second Request Chrome
-------------xxx-----------
From DependencyService1
- Transient - 398f80f3-6ce9-4b4f-8445-b0fde99ded8e
- Scoped - fa350e12-fa3c-4aa3-8903-fc606a7c1718
- Singleton - 93fefd73-db11-4713-a305-e0a5468f522e
- Singleton Instance - 00000000-0000-0000-0000-000000000000

-------------xxx-----------
From DependencyService2
- Transient - 9df26503-b3e5-4f0e-9718-5fab0238a465
- Scoped - fa350e12-fa3c-4aa3-8903-fc606a7c1718
- Singleton - 93fefd73-db11-4713-a305-e0a5468f522e
- Singleton Instance - 00000000-0000-0000-0000-000000000000




















1. **Creational Patterns**:
- **Singleton**: Ensures a class has only one instance and provides a global point of access to it.
- **Factory Method**: Defines an interface for creating an object but allows subclasses to alter the type of objects that will be created.
- **Abstract Factory**: Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
- **Builder**: Separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

2. **Structural Patterns**:
- **Adapter**: Allows the interface of an existing class to be used as another interface.
- **Decorator**: Attaches additional responsibilities to an object dynamically, providing a flexible alternative to subclassing for extending functionality.
- **Proxy**: Provides a surrogate or placeholder for another object to control access to it.
- **Composite**: Composes objects into tree structures to represent part-whole hierarchies.

3. **Behavioral Patterns**:
- **Observer**: Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
- **Strategy**: Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
- **Command**: Encapsulates a request as an object, thereby allowing for parameterization of clients with queuing, requests, and operations.
- **State**: Allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

4. **Architectural Patterns**:
- **MVC (Model-View-Controller)**: Separates an application into three interconnected components - Model, View, and Controller.
- **MVVM (Model-View-ViewModel)**: Extends the MVC pattern by introducing a ViewModel to separate the UI and the business logic.
- **Repository**: Separates the logic that retrieves data from a data source from the business logic, providing a single access point to the data.

5. **Concurrency Patterns**:
- **Producer-Consumer**: Coordinates the activities of separate threads or processes producing and consuming data items.
- **Semaphore**: Controls access to a common resource with limited capacity.
- **Reader-Writer Lock**: Provides synchronization for multiple threads reading a resource while allowing only one thread to write to it.

These design patterns serve as best practices and proven solutions to common software design problems. They help developers create maintainable, modular, and efficient code by promoting the separation of concerns and the use of well-established design principles. Depending on the problem at hand, different design patterns can be applied to achieve the desired software architecture and behavior.