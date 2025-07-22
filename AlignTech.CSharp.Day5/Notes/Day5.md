Anonymous Types

Typed variable(var \& dynamic)

Intro to delegates

Single and Multicast Delegate

Anonymous methods,

Events in c#"

------------------------------------------------



What Are Anonymous Types?

Anonymous types in C# are unnamed class types created using the new keyword and object initializer syntax. They were introduced in C# 3.0 to simplify scenarios where you need a temporary data structure without explicitly defining a class.



Key Characteristics

\- Compiler-generated type: The compiler creates a sealed class behind the scenes.

\- Read-only properties: All properties are immutable.

\- Reference type: Derived from System.Object.

\- Scoped locally: Cannot be returned from methods or used as method parameters (except via object or dynamic).

\- No methods or events: Only properties are allowed.



Example:

var book = new { Title = "C# in Depth", Author = "Jon Skeet", Pages = 900 };

Console.WriteLine(book.Title); // Output: C# in Depth



Note:

\- You can access properties using dot notation.

\- Properties are inferred based on the values provided.



Nested Anonymous Types

Anonymous types can contain other anonymous types

Commonly used in LINQ queries to project a subset of properties



Example:

var employee = new {

&nbsp;   Name = "Kayal",

&nbsp;   Contact = new { Email = "kayal@example.com", Phone = "8888889999" }

};

Console.WriteLine(employee.Contact.Email);



Limitations

Cannot be used as:

\- Return types

\- Method parameters (unless object or dynamic)

\- Fields or properties in other classes

\- Cannot contain methods, events, or indexers

\- Cannot be cast to any type other than object



Implicitly typed variable

var Keyword

\- Implicitly typed: Compiler infers the type from the assigned value.

\- Type is fixed: Once inferred, it cannot be changed.

\- Requires initialization: Must be assigned at declaration.

\- Used for local variables only.



dynamic Keyword

\- Type resolved at runtime.

\- Flexible: Can change type during execution.

\- No IntelliSense: Because type is unknown at compile time.

\- Can be used as method parameters, return types, and properties.







**Delegates**



A delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate the delegate instance with any method that has a compatible signature and return type. You can invoke (or call) the method through the delegate instance.



Steps to follow when using delegate.

1. Declare a delegate type and declare a method with a matching signature
   Delegates define the method signature (what parameters and return type a method should have).
2. Assign a method group to a delegate type
   Only methods matching this signature can be assigned to the delegate.
3. Use the delegate(By calling object of delegate)



Example:

*public delegate void ShowMessage(string msg); // Step 1: Define*



*public class Person {*

&nbsp;   public void Greet(string text) => Console.WriteLine(text);
    public void GreetWithName(string text) => Console.WriteLine($"{text}, Arun");

*}*



*Person g = new Person();*

*ShowMessage sm = g.Greet;   // Step 2: Assign*

*sm("Welcome");*        // Step 3: Use



**Single Delegate**

A single delegate holds a reference to one method.



Characteristics:

\- Calls only one method at a time.

\- Simpler to manage and understand.

\- Typically used in basic scenarios like callbacks or event handlers.



**Multicast Delegate**

A multicast delegate holds references to multiple methods with the same signature.



Characteristics:

\- Methods are invoked in the order they are added.

\- Can use += to attach multiple methods.

\- Return value is only from the last method (if there's a return type).

\- Especially useful in event-driven programming.



Example:

*ShowMessage sm += g.GreetWithName; //Assign another method to the delegate.*



What Are Anonymous Methods?

Anonymous methods are inline methods without a name. They allow you to define a block of code using the delegate keyword and assign it directly to a delegate variable—without creating a separate method.

\- No method name

\- Can access outer variables (closure)

\- Must match the delegate signature



Example:

delegate void Greet(string name);

Greet greet = delegate(string name) {

&nbsp;   Console.WriteLine($"Hello, {name}!");

};

greet("Arun");



When to use?

\- Event handling: Simplifies attaching logic to events

\- One-time logic: Ideal for short-lived delegate assignments

\- LINQ and callbacks: Predecessor to lambda expressions







**Event**

Events are a way for a class (publisher) to notify other classes (subscribers) when something happens. 

It is declared using the *event* keyword and is based on a delegate type. 

When an event is raised, all subscribed event handlers (delegate instances) are invoked.



Concepts:

Publisher: The class that defines and raises the event.

Subscriber: The class that listens and responds to the event.

Delegate: Defines the method signature for event handlers.

Event: A wrapper around a delegate, declared using the event keyword.





Example:

public delegate void ShowMessage(string message);//Declare a delegate

*public event ShowMessage OnAlarm; // Declare the event*

*OnAlarm?.Invoke("Alarm is ringing!"); // Call the event*



&nbsp;Best Practices

\- Name event-raising methods with On<EventName>.

\- Use system defined delegate EventHandler or EventHandler<T> unless you need a custom delegate.

\- Always check for null before invoking events.

\- Keep event data minimal and relevant.



