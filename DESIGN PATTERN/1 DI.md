


## DEPENDENCY INJECTION
### Dependecny Injection
- Dependency Injection (DI) is a software design pattern that deals with how components or services obtain their dependencies. In object-oriented programming, a class often depends on other classes or services to fulfill its responsibilities. Dependency Injection is a way to achieve inversion of control (IoC) by providing dependencies from the outside rather than creating them within the class.

### Dependency Inversion
- Dependency Inversion is another principle in software design that complements the Dependency Injection pattern. It is part of the SOLID principles, specifically the Dependency Inversion Principle (DIP), which was introduced by Robert C. Martin. The Dependency Inversion Principle states.
1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
2. Abstractions should not depend on details. Details should depend on abstractions.

### What is Service LifeTimes?
1. Transient -> Create each time they are requested from the service container,
2. Scoped -> Created Once per client request (connection)
3. Singleton -> Created at the first time they are requested (or when Startup.ConfigureServices is run and an instance is specified with the service registration). Every subsequent request uses the same instance. If the app requires singleton behaviour, allowing the service container to manage the service's lifetime is recommended. Don't implement the singleton design pattern and provide user code to manage the object's lifetime in the class.

### DI LifeTime Dotnet Core API
#### First Request Chrome
-------------xxx-----------
From DependencyService1
- Transient - 4a3256f2-b319-4d64-bbc3-856d4eefe38e // New for Every Class
- Scoped - 31764c5c-c8df-471f-9b61-06085a3d2f0d // Each for Request
- Singleton - 93fefd73-db11-4713-a305-e0a5468f522e // Same for every Request
- Singleton Instance - 00000000-0000-0000-0000-000000000000 // Same for every Request (When Registering Instance Twice)

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
