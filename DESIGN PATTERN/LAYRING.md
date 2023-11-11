## Donation.Api

### Depends on 
- Donation.Contracts
- Donation.Application
- Donation.Infrastructure

### Purpose of this Layer
- Controllers, Endpoints
- Entry point of your application
- Can be used as (Web Api, MVC, Razor Pages, SPA (Angular, React, Vue))

## Application Layer

### Purpose of this Layer
- This layer contains the application services that coordinate the interactions between the Core and Infrastructure layers.

### Depends On

- Domain Layer

## Contract 

### Purpose of this Layer
- The contract layer is a layer that is sometimes used in Clean Architecture to define the interface that other layers should use to interact with the domain layer. It serves as a bridge between the domain layer and the rest of the application, providing a clear and consistent interface for the other layers to use.

- Note that the contract layer is not a requirement for Clean Architecture, and some implementations may choose to skip this layer, instead defining the interfaces directly in the domain layer. The important thing is to provide a clear separation between the domain layer and the other layers, regardless of whether a contract layer is used or not.

### Depends on
- For Now it is not also depends on Other Layer just like Domain Layer

## Domain / Core Layer

### Purpose
- The domain layer, also known as the Core layer, is the innermost layer in Clean Architecture and serves as the heart of the application. Its purpose is to contain the business logic and domain models that define the core functionality and behavior of the application.

### Depends On
- Does not Depends on Any Layer


## Infrastructure

### Purpose
- This layer contains the implementation of the interfaces defined in the Core layer, such as data access and logging.

### Depends On
- Application Layer

### Example