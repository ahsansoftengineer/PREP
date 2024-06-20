## PROGRAMMING PARADIGMS

1. Procedural Prog, Object Oriented Prog, Functional Prog

## OOP 
| Heading | Defination |
|:-------:|:---------- | 
| Inheritance  | Inheritance is typically used to create a hierarchy of classes, where each child class adds new or modified behavior to the parent class. This allows developers to reuse code and avoid duplicating functionality across multiple classes. |
| Abstraction | Abstraction is a fundamental concept in object-oriented programming (OOP) that allows developers to focus on the essential features of an object, while hiding its complex implementation details. Abstraction is the process of creating a simplified representation of something, with the aim of reducing complexity and making it easier to work with. |
| Polymorphism | There are two main types of polymorphism in OOP: compile-time (or static) polymorphism and runtime (or dynamic) polymorphism. |
| Pholymorphism Compile Time / Static | Compile-time polymorphism is achieved through method overloading, which allows multiple methods with the same name to exist in a class, but with different parameters or return types.   | 
| Pholymorphism Run Time / Dynamic | Runtime polymorphism is achieved through method overriding, which allows a child class to provide its own implementation of a method that is already defined in the parent class. | 
| Encapsulation | Encapsulation is a fundamental concept in object-oriented programming (OOP) that refers to the practice of hiding the implementation details of an object from the outside world, while exposing a public interface for interacting with the object |


### OOP (Inheritance, Encapsulation, Polymorphism, Abstraction)
Object-Oriented Programming (OOP) is a programming paradigm that organizes code into objects, which are instances of classes. OOP is based on the following key concepts:

1. **Classes and Objects**: 
- A class is a blueprint or template that defines the structure and behavior of objects.
- An object is an instance of a class and contains both data (attributes) and methods (functions) that operate on the data.

2. **Encapsulation**:
- Encapsulation is the concept of bundling data and the methods that operate on that data into a single unit (an object).
- It helps protect the data by controlling access to it and ensures that data is only modified in a controlled manner through methods.
- Encapsulating Properties, Methods, Constructor

3. **Inheritance**:
- Inheritance allows you to create a new class that is a modified version of an existing class. The new class inherits attributes and behaviors from the existing class.
- It promotes code reuse and establishes a hierarchy of classes.

4. **Polymorphism**:
- Compile-time Polymorphism: Method Overloading
```c# 
int funcName(int a)
int funcName(float b)
funcName(10);
// The compiler would choose the most appropriate function based on the provided argument type and the available function signatures. 
// If there's ambiguity or no exact match, it could result in a compilation error.
```
5. **Abstraction**:
- Abstraction involves simplifying complex systems by modeling classes based on their essential properties and behaviors.
- It hides the unnecessary details while exposing only what is relevant, making the code more understandable and maintainable.

OOP promotes the organization of code into modular and reusable components, making it easier to understand, maintain, and extend software systems. It's a widely used programming paradigm in languages like Java, C++, C#, and many others.


1. Polymorphism  Overloading, Overriding, Hiding (Virtual, Override)