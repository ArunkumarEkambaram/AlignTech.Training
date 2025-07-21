Properties, Auto Implement Properties,

Exception Handling,

Try, catch, finally and throw keywords,

Creating custom Exception





Properties in C#

What Are Properties?

Properties in C# are members of a class that provide a flexible mechanism to read, write, or compute the values of private fields.

They act like public data members but use methods (getters and setters) behind the scenes.



Why Use Properties?

\- To control access to class fields

\- To add validation logic when getting or setting a value

\- To encapsulate internal data



Example:

private int \_age; // backing field



public int Age  // property

{

    get { return \_age; }

    set { \_age = value; }

}

Benefits

\- Encapsulation: Keeps internal data safe

\- Validation: Add logic to control what values are allowed

\- Abstraction: Hides implementation details



**Auto-Implemented Properties**

Auto-implemented properties simplify property declarations when no additional logic is needed in the get or set blocks.

The compiler automatically creates a private, anonymous backing field

Example:

public string Name { get; set; }



Note:

Properties can be read-only or write-only



Read-Only

public string Brand { get; } = "Tata";



Write-Only(rarely used)

private string \_secretKey;

public string SecretKey

{

&nbsp;   set { \_secretKey = value; }

}





Exception Handling

Exception Handling is a way to gracefully handle runtime errors so your program doesn't crash unexpectedly. 

An exception is an unexpected event or error that occurs while a program is running.



System.Object

&nbsp; └── System.Exception

&nbsp;       ├── System.SystemException

&nbsp;       │     ├── DivideByZeroException

&nbsp;       │     ├── NullReferenceException

&nbsp;       │     └── IndexOutOfRangeException

&nbsp;       └── System.ApplicationException (used for custom exceptions)





Common Causes of Exceptions

\- Dividing by zero

\- Accessing null objects

\- File not found

\- Invalid type conversions



try

Contains the code that may cause an exception.



catch

Handles the exception that occurred in try.



finally

Executes regardless of whether an exception occurred.

Used to release resources (e.g., file handles, DB connections).



throw

Used to manually raise an exception.



Syntax:

try

{

&nbsp;   // Risky code that might throw an exception

}

catch (Exception ex)

{

&nbsp;   // Code to handle the exception

}

finally

{

&nbsp;   // Cleanup code, always executed

}





Throwing Custom Exception

You can raise your own exception with the throw keyword.

Example:

throw new Exception("Something went wrong!");



Rethrowing an Existing Exception

*throw;* (without variable) is preferred when you want to rethrow without losing the original stack trace.



Custom Exception:

Custom exceptions are user-defined exceptions that derive from the built-in Exception class. They allow you to communicate specific errors in your domain logic that aren't covered by system exceptions.



Why Use Custom Exceptions?

\- To create domain-specific error types (e.g. InvalidAgeException)

\- Improve code readability and maintainability

\- Enable fine-grained exception handling

\- Distinguish between expected business exceptions and unhandled system faults



Example:

public class InvalidAgeException : Exception

{

&nbsp;   public InvalidAgeException(string message) : base(message)

&nbsp;   {

&nbsp;   }

}



Catching the Custom Exception

try

{

&nbsp;   Person p = new Person();

&nbsp;   p.SetAge(200);

}

catch (InvalidAgeException ex)

{

&nbsp;   Console.WriteLine("Custom Error: " + ex.Message);

}





Best Practice

\- Catch specific exceptions instead of general Exception

\- Use finally for cleanup (e.g., closing files or database connections)

\- Avoid excessive use of exceptions for regular control flow



