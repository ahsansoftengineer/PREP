
In C#, MethodBase is an abstract class provided by the .NET Framework that represents a method or constructor in reflection. It is part of the System.Reflection namespace.

1. MethodBase serves as a base class for MethodInfo and ConstructorInfo, which represent specific types of methods and constructors, respectively. It provides common functionality and properties that can be used to retrieve information about a method or constructor at runtime.
- Name: Gets the name of the method.
- IsAbstract: Gets a value indicating whether the method is abstract.
- IsStatic: Gets a value indicating whether the method is static.
- IsPublic: Gets a value indicating whether the method is public.
- IsPrivate: Gets a value indicating whether the method is private.
- IsVirtual: Gets a value indicating whether the method is virtual.
- GetParameters(): Retrieves an array of ParameterInfo objects representing the parameters of the method.
- Invoke(object obj, object[] parameters): Invokes the method with the specified parameters on the specified object.
- By using MethodBase, you can perform reflection operations on methods and constructors, such as retrieving information about their accessibility, modifiers, parameters, and invoking them dynamically at runtime.

2. Base Classes Reflection
- MethodInfo : MethodBase : MemberInfo
- MethodInfo : > GetGenericArguments, GetGenericMethodDefinition, MakeGenericMethod, GetBaseDefinition, ReturnTypeCustomAttributes, CreateDelegate
- MethodBase : > GetParameterTypes, GetParametersNoCopy, GetGenericArguments
- MemberInfo : > HasSameMetadataDefinitionAsCore, CacheEquals