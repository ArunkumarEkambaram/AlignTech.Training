Extension Methods

Enum

Attribute

Custom Attributes

Reflection

Late Binding





**Extension methods**



Extension methods let you add new methods to existing types (classes, structs, interfaces) without modifying their source code or using inheritance.

They’re defined as static methods but behave like instance methods on the extended type



Syntax Rules

\- Must be inside a static class

\- Must be a static method

\- The first parameter must be prefixed with **this** and specify the type being extended



Example:

public static void Print(this MyClass obj) {

    Console.WriteLine("Extension method called");

}



Extension Methods vs Inheritance

| Feature 		| Extension Methods 		| Inheritance |

| Source Code Access 	| Not required 			| Required |

| Works with Sealed 	| Yes 				|  No |

| Method Overriding 	| Not supported 		|  Supported |

| Flexibility 		| High (can extend any type) 	|  Limited to base types |





Limitations

\- Cannot override existing methods

\- Cannot access private members of the extended type

\- Only one binding parameter allowed (the this parameter)

\- Not applicable to fields, properties, or event



Best Practices

\- Use meaningful method names

\- Keep logic concise and focused

\- Avoid overusing extension methods for core business logic

\- Group related extensions in dedicated static classes



**Enum**

An enum (short for enumeration) is a value type in C# that defines a set of named constants.

It improves code readability, type safety, and maintainability by replacing magic numbers with meaningful names.

You can specify a different integral type

Use **\[Flags]** to combine **enum** values using bitwise operators

Makes your code self-explanatory and easier to maintain.



Example:

*enum Status {*

    Pending,
Approved,
Rejected

*}*



By default:

\- The underlying type is int

\- The first member has value 0, and each subsequent member increments by 1





**Reflection**



Reflection in C# is a powerful feature that allows a program to inspect and interact with its own metadata or the metadata of other assemblies at runtime. It provides a way to dynamically examine and manipulate types, objects, methods, properties, and other elements of a program without knowing their details at compile time. Reflection is part of the System.Reflection namespace in .NET.



\- Retrieve information about types (classes, interfaces, structs, etc.), their members (methods, properties, fields, events), and attributes.

\- Dynamically create instances of types

\- Invoke methods and access members

\- Inspect and manipulate custom attributes.

\- Load and explore assemblies



Key Components of Reflection

* **Type:** Represents a type (class, interface, etc.) and provides metadata like methods, properties, and fields.
* **Assembly:** Represents a compiled .NET assembly and allows you to explore its types and resources.
* **MethodInfo, PropertyInfo, FieldInfo:** Classes that provide details about methods, properties, and fields of a type.
* **Activator:** A utility class to create instances of types dynamically.



**Basic usage:**

**Get Type Information**

Type type = typeof(string);

Console.WriteLine(type.FullName); // Output: System.String





 Core Components of Reflection

| Class 			| Purpose |

| Type 				| Represents metadata about a type |

| MethodInfo 			| Info about methods |

| PropertyInfo 			| Info about properties |

| FieldInfo 			| Info about fields |

| ConstructorInfo 		| Info about constructors |

| Assembly 			| Represents a loaded assembly |

| ParameterInfo 		| Info about method parameters |





**How Reflection is Used in Real-Time**

Reflection is used in scenarios where the type or structure of objects is unknown at compile time or needs to be determined dynamically.



**Real-Time Use:** Dependency injection frameworks like ASP.NET Core's built-in DI container or third-party libraries (e.g., Autofac) use reflection to instantiate and inject dependencies dynamically based on registered types.



**Inspecting Type Metadata**

Reflection is used to inspect the structure of types, such as listing all methods, properties, or fields of a class. This is common in tools like debuggers, ORMs, or serialization libraries.

Example: Listing all properties of a class



**Dynamic Method Invocation**

Reflection allows invoking methods dynamically, which is useful in scenarios like scripting engines or plugin systems where method names are determined at runtime.

Example: Invoking a method dynamically based on its name.



**Working with Attributes**

Reflection is used to read custom attributes applied to classes, methods, or properties, which is common in frameworks for configuration or validation.

Example: Reading a custom attribute.



**Dynamic Assembly Loading**

Reflection can load assemblies dynamically, which is useful in plugin systems or modular applications.

Example: Loading an assembly and creating an instance.



**Unit Testing Frameworks**

Unit testing frameworks like MSTest, NUnit, or xUnit use reflection to discover and execute test methods marked with attributes like \[Test] or \[TestMethod].

Example: A testing framework might scan an assembly for methods with the \[Test] attribute and invoke them dynamically.



**Real-World Scenarios**

**ASP.NET Core:** Uses reflection to discover controllers, actions, and attributes for routing, dependency injection, and middleware configuration.

**Entity Framework Core:** Maps database tables to C# classes by inspecting properties and their attributes.

**Mocking Frameworks:** Tools like Moq use reflection to create dynamic proxies for mocking interfaces or classes.



**Attribute**

Attributes in C# are a form of metadata that can be applied to various program elements such as classes, methods, properties, fields, and assemblies. They provide additional information about these elements, which can be queried and used at runtime through reflection. Attributes are defined in the **System.Attribute** class and are typically used to add declarative information or control behavior in frameworks, tools, or runtime environments.



**Key Points about Attributes**

**Declarative:** Attributes are applied using square brackets (\[]) before the target element.

**Runtime Access:** Attributes can be inspected at runtime using reflection (from the System.Reflection namespace).

**Built-in Attributes:** .NET provides many built-in attributes (e.g., \[Obsolete], \[Serializable], \[DataMember]).

**Custom Attributes:** You can create your own attributes by inheriting from System.Attribute.

**Usage:** Attributes are widely used in frameworks like ASP.NET Core, Entity Framework, and unit testing frameworks for configuration, validation, or behavior modification.



Syntax:

*\[AttributeName(Parameter1, Parameter2)]*

*public class MyClass { }*



**Attributes are used in the following scenarios:**



Marking methods or classes as deprecated (\[Obsolete]).

Configuring serialization (\[Serializable], \[DataMember]).

Defining metadata for ORMs like Entity Framework (\[Key], \[Table]).

Controlling behavior in frameworks like ASP.NET Core (\[Route], \[Authorize]).

Annotating test methods in unit testing frameworks (\[Test], \[TestMethod]).



**Custom Attribute**

You can create a custom attribute by inheriting from System.Attribute and use it to add metadata to program elements.





**Custom attribute definition:**

\[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]

public class DescriptionAttribute : Attribute



**Example:**

using System;

using System.Reflection;



// Custom attribute

public class InfoAttribute : Attribute

{

    public string Description { get; }

    public InfoAttribute(string description) => Description = description;

}



// Class with attribute

\[Info("This is a test class")]

public class TestClass

{

    public void SayHello() => Console.WriteLine("Hello!");

}



class Program

{

    static void Main()

    {

        // Using Reflection to read attribute

        Type type = typeof(TestClass);

        var attribute = (InfoAttribute)Attribute.GetCustomAttribute(type, typeof(InfoAttribute));

        Console.WriteLine($"Description: {attribute.Description}"); // Output: Description: This is a test class



        // Using Reflection to create object and call method

        object instance = Activator.CreateInstance(type);

        MethodInfo method = type.GetMethod("SayHello");

        method.Invoke(instance, null); // Output: Hello!

    }

}



