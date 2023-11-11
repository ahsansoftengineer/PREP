- ReactiveX combines the Observer pattern with the Iterator pattern and functional programming with collections to fill the need for an ideal way of managing sequences of events.

The essential concepts in RxJS which solve async event management are:
- Observable: represents the idea of an invokable collection of future values or events.
- Observer: is a collection of callbacks that knows how to listen to values delivered by the Observable.
- Subscription: represents the execution of an Observable, is primarily useful for cancelling the execution.
- Operators: are pure functions that enable a functional programming style of dealing with collections with operations like map, filter, concat, reduce, etc.
- Subject: is equivalent to an EventEmitter, and the only way of multicasting a value or event to multiple Observers.
- Schedulers: are centralized dispatchers to control concurrency, allowing us to coordinate when computation happens on e.g. setTimeout or requestAnimationFrame or others.

1. **Definition:**
   - The Observable Design Pattern is a behavioral design pattern where an object, known as the "subject" or "observable," maintains a list of its dependents, called "observers," and notifies them of any state changes.

2. **Components:**
   - **Subject (Observable):** The object being observed. It maintains a list of observers and provides methods to add, remove, and notify observers.
   - **Observer:** An interface or abstract class with an update method that concrete observers implement to respond to changes in the subject.
   - **ConcreteSubject:** A specific implementation of the subject that contains the actual state and triggers notifications to observers.
   - **ConcreteObserver:** A specific implementation of the observer that defines how it should react to updates from the subject.

3. **Registration and Notification:**
   - Observers register themselves with the subject to receive notifications.
   - When the subject's state changes, it notifies all registered observers, typically by calling their update methods.

4. **Use Cases:**
   - Useful when you have a one-to-many relationship between objects, and changes to one object should automatically notify and update multiple dependent objects.
   - Commonly used in implementing distributed event handling systems.

6. **Custom Implementation:**
   - Many developers prefer creating custom implementations of the Observable pattern rather than using built-in Java classes. This allows for more control and flexibility in designing the notification mechanism.

7. **Loose Coupling:**
   - The Observable pattern promotes loose coupling between subjects and observers. Observers are not directly aware of the concrete class of the subject; they depend on the subject's interface.

8. **Drawbacks:**
   - Overhead: Maintaining a list of observers and notifying them can introduce some overhead, especially if there are many observers.
   - Limited Information: Observers are notified without specific details about the change, so they may need to query the subject for additional information.

9. **Alternatives:**
   - Alternatives to the Observable pattern include using event listeners, callbacks, or more modern reactive programming libraries for handling asynchronous events.