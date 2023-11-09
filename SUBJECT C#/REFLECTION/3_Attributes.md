### Purpose of Attributes
1. Metadata and behavior: Attributes can provide metadata about code elements or influence their behavior. They can carry information such as author, version, description, or configuration settings.

2. Reflection: At runtime, you can use reflection to inspect attributes applied to code elements. Reflection APIs allow you to retrieve attribute instances and extract the information they contain.

### Attribute Args
1. We can Only pass the Args that already evaluate by the Compiler 
2. Cannot pass those args those are not evaluated to Attributes

### Applying Attributes
1. Assembly
2. Class
3. Properties
4. get set
5. return
6. Methods
7. Methods Args

### Restricting Attribute
1. Restricting Attribute to Apply at Class Level | the Method Level

### Default Attribute
1. Obsolete
2. Conditional
3. Required, Min, Max
4. Controller, Api, Swagger,
5. DebuggerDisplay, DebuggerStepThrough
### Conditional Attribute
1. ConditionalAttribute used with Preprocessor Directives 
2. It removes the Functions and its calls 
3. Useful for Development Purpose