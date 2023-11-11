Angular, being a front-end web development framework, leverages several design patterns to provide a modular, maintainable, and scalable architecture. Here are some design patterns commonly used in Angular:

1. **Module Pattern:**
   - **Description:** Organizes code into modules, encapsulating related functionality together. Angular modules (`@NgModule`) are a built-in implementation of this pattern.

2. **Component Pattern:**
   - **Description:** Decomposes the user interface into smaller, reusable components. Each component encapsulates its own logic and view.

3. **Dependency Injection (DI):**
   - **Description:** Promotes the use of dependency injection for managing the creation and lifecycle of application components. Angular's dependency injection system allows you to inject services into components and other services.

4. **Singleton Pattern:**
   - **Description:** Ensures that a class has only one instance and provides a global point of access to it. Angular services, when registered at the application level, act as singletons.

5. **Observer Pattern:**
   - **Description:** Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. In Angular, this pattern is commonly used with Observables and the `subscribe` method for handling asynchronous events.

6. **Decorator Pattern:**
   - **Description:** Allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class. Angular decorators, such as `@Component` and `@Injectable`, extend the behavior of classes.

7. **State Pattern:**
   - **Description:** Allows an object to alter its behavior when its internal state changes. In Angular, state management libraries like NgRx or services that manage application state can be considered implementations of this pattern.

8. **Facade Pattern:**
   - **Description:** Provides a simplified interface to a set of interfaces in a subsystem. Angular services often act as facades, providing a simplified API to interact with complex functionality.

9. **Strategy Pattern:**
   - **Description:** Defines a family of algorithms, encapsulates each one, and makes them interchangeable. In Angular, this pattern is often implemented with different strategies for form validation or HTTP request handling.

10. **Template Method Pattern:**
    - **Description:** Defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure. In Angular, this pattern is reflected in the lifecycle hooks of components.

These design patterns contribute to the overall structure and architecture of Angular applications, promoting separation of concerns, maintainability, and reusability. Understanding and applying these patterns can lead to more effective and scalable Angular development.