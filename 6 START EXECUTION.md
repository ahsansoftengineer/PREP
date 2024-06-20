#### Q1. What happens when Dotnet Application Starts Running?
1. **Compilation:**
   - The source code written in a .NET language (C#, VB.NET, etc.) is compiled into Intermediate Language (IL) or Common Intermediate Language (CIL) by the language compiler.
2. **Assembly Generation:**
   - The IL code is stored in assemblies. Assemblies contain metadata, manifest, and the IL code. Assemblies can be in the form of executable (.exe) or dynamic link library (.dll) files.
3. **Common Language Runtime (CLR) Activation:**
   - When the .NET application is executed, the CLR is activated. The CLR is responsible for managing and executing .NET code.
4. **Loading of Assembly:**
   - The CLR loads the required assemblies into the memory. This includes the main assembly and any referenced assemblies.
5. **Metadata and Manifest Processing:**
   - The CLR reads metadata from the assemblies, which contains information about types, members, and references. The manifest provides information about the assembly itself.
6. **Just-In-Time Compilation (JIT):**
   - The IL code is not directly executed by the computer's hardware. Instead, the CLR uses a Just-In-Time Compiler to convert the IL code into native machine code specific to the underlying hardware. This happens at runtime.
7. **Type Loading and Verification:**
   - The CLR loads types into memory as needed and performs type verification to ensure type safety.
8. **Execution of Main Method:**
   - The CLR locates and executes the entry point of the application, typically the `Main` method in the primary class.
9. **Execution of Code:**
   - As the application runs, the CLR manages memory, handles exceptions, and provides various services like garbage collection.
10. **Garbage Collection:**
    - The CLR includes a garbage collector that automatically deallocates memory that is no longer in use, preventing memory leaks.
11. **Exception Handling:**
    - The CLR provides a robust exception handling mechanism to catch and manage runtime errors.
12. **Termination:**
    - When the application completes its execution or encounters an unhandled exception, it terminates, and the CLR performs cleanup tasks.

In summary, the .NET application startup involves compilation, assembly loading, metadata processing, JIT compilation, type loading, and execution under the management of the Common Language Runtime. This process ensures that .NET applications are platform-independent and can take advantage of features like memory management and exception handling provided by the CLR.

#### Q2. What happens when Express.js Application Starts Running?
1. When an Express.js API application starts running, a number of things happen in order to initialize the application and get it ready to handle incoming requests. Some of the main steps that occur include:

2. The Node.js runtime is initialized. Express.js is built on top of Node.js, which provides an environment for executing JavaScript code on the server side.

3. The application's dependencies are loaded. Express.js applications are built using a number of modules and packages, which are specified in the application's package.json file. These dependencies are loaded into the application's environment when the application starts.

4. The Express.js application is configured. The application's main JavaScript file typically sets up the Express.js application by creating an instance of the Express.js application, configuring middleware, and setting up routes.

5. The application begins to listen for incoming requests. This is typically done by calling the listen method on the Express.js application instance, and passing in a port number and an optional callback function.

6. Once the application is running, it will continue to process incoming requests until it is shut down or otherwise stopped. Express.js uses a callback function for each route to handle request and send the response

7. Depending on the design, the application may also connect to a database and initialize any necessary data models or perform other operations required for the application to function.

#### Q3. What happens when Angular application start running?
1. When an Angular application starts running, a number of things happen in order to initialize the application and get it ready to handle user interactions. Some of the main steps that occur include:

2. The Angular framework is loaded. Angular is a JavaScript framework, and it is loaded along with the application's JavaScript code, typically via a script tag in the HTML page.

3. The application's modules and components are loaded. Angular applications are organized into modules, which are made up of individual components. These components are defined using TypeScript classes and Angular decorators.

4. The application's bootstrap module is executed. The bootstrap module is a special module that is responsible for starting the application. It's typically defined in the "main.ts" file and contains the code that tells Angular to start the application by bootstrapping the root component.

5. The component tree is rendered. Once the bootstrap module is executed, Angular takes the root component and uses it to create a component tree. It then renders the component tree by updating the DOM with the component's templates and any dynamic data.

6. The application begins to listen for user interactions. Angular uses a powerful event system and change detection mechanism, that allows the application to respond to user interactions and updates to data in real-time.

7. The application may also initiate communication with a back-end service via HTTP calls or WebSockets and initialize necessary data models or perform other operations required for the application to function.

8. Once the application is running, it will continue to process user interactions and update the component tree and the DOM as necessary.