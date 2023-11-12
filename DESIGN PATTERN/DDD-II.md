### VS (TDD, BDD, DDD)

1. **Domain-Driven Design (DDD):**
   - **Definition:** Domain-Driven Design is an approach to software development that focuses on understanding and modeling the business domain. It was introduced by Eric Evans in his book "Domain-Driven Design: Tackling Complexity in the Heart of Software."
   - **Key Concepts:**
     - **Ubiquitous Language:** Encourages the use of a common language that is shared by both developers and domain experts to eliminate ambiguity in communication.
     - **Bounded Contexts:** Defines explicit boundaries within which a particular model is defined and applicable.
     - **Aggregates:** Clusters of related entities and value objects that are treated as a single unit.

2. **Test-Driven Development (TDD):**
   - **Definition:** Test-Driven Development is a software development process in which tests are written before the code they are intended to validate. The cycle typically involves writing a test, writing the minimum amount of code to pass that test, and then refactoring the code.
   - **Key Steps in TDD:**
     - **Red:** Write a failing test that defines a piece of functionality.
     - **Green:** Write the minimum amount of code to make the test pass.
     - **Refactor:** Refactor the code while keeping it functional.

3. **Behavior-Driven Development (BDD):**
   - **Definition:** Behavior-Driven Development is an agile software development technique that encourages collaboration among developers, QA, and non-technical or business participants in a software project. It extends TDD by using natural language descriptions to define software behaviors.
   - **Key Components:**
     - **User Stories/Scenarios:** Descriptions of how the system should behave, often written in natural language that can be understood by non-technical stakeholders.
     - **Given-When-Then:** A structure for describing the conditions (Given), the actions (When), and the expected outcomes (Then) of a particular scenario.

In summary:
- **DDD** focuses on understanding and modeling the business domain.
- **TDD** emphasizes writing tests before writing the actual code to ensure that the code meets the specified requirements.
- **BDD** extends TDD by involving non-technical stakeholders, using natural language to describe software behavior, and often employing tools like Cucumber or Behave for automated testing.
