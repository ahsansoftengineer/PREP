### MICROSERVICE ARCH
[Youtube Video](https://www.youtube.com/watch?v=3UDJvF0CMkQ&list=PLTCrU9sGyburHcVKRuw2yXt7V7HEa6ZYY&index=7)
 
### What are Microservices
- Microservices are an architectural style where an application is divided into small, independent services, each focusing on a specific business function. These services communicate through APIs and can be developed, deployed, and scaled independently, offering flexibility, scalability, and resilience. However, they introduce complexity in managing distributed systems and ensuring data consistency.
1. Single Responsibility
2. Decentralized Data Management
3. Autonomous and Loosely Coupled
4. Technology Agnostic (Different Services can use Different Language, Framework)
5. Continuous Delivery and Deployment
6. Fault Isolation (1 Service Failure doesn't let Whole Application Down)
7. Scalability (Service can be Scale Up / Down Depending on Usage)


#### COMM TYPE
#### DISTRIBUTED TRANSACTION
#### EVENT BASED COMM
1. Problems
- Lost Messages
- Order of Messages
- Consumer at fault
2. Solutions
- Retrials, Replays
- Retention of Messages
- Sending same message twice

#### TYPES OF COUPLING (COHESION & LOW COUPLING)
- Cohesion is the degree to which the elements inside a module belong together. A module could be a class or a package or even a Microservice. Simply put, it means **The Code that changes together, stays together**

- Coupling is the degree of interdependence between software modules. A module could be a class or a package or even a Microservice. Effectively, the coupling is about how changing one thing required change in another.
##### 4 TYPES OF COUPING
1. Domain
2. Pass-through
3. Content
4. Common

#### LOGGING, MONITORING & TRACING
#### SERVICE DISCOVERY
#### SIDE CAR PATTERN
#### EVENT SOURCING


