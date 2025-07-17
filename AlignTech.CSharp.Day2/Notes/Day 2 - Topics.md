**Day 2 - Topics**

Partial class

Define Methods

Parameter by value, ref and out

Constructor and Destructor

Access Modifiers



**Partial Class**



A partial class allows the definition of a single class to be split into multiple files. All parts are combined during compilation.



Why partial class?

* Separation of concerns
* Organize large classes
* Support auto-generated code (e.g., in WinForms or Entity Framework)



All parts must use the **partial** keyword and have the same access modifier and class name.

Can also be used with structs, interfaces, and methods (in C# 9+).

Helpful when multiple developers are working on the same class.



//class1.cs



*public partial class Employee {*

&nbsp;   \*public void Display() {\*

        \*Console.WriteLine("Employee Details");\*

    \*}\*


*}*



//class2.cs



*public partial class Employee {*

&nbsp;   \*public void CalculateSalary() {\*

        \*Console.WriteLine("Salary Calculated");\*

    \*}\*


*}*



**Define Methods**

* A method is a block of code that performs an action.
* Methods are extremely useful because they allow you to define your logic once, and use it, at many places.
* Methods make the maintenance of your application easier.



syntax:

public returnType MethodName(parameters) {

    // method body

}



Method Parameter(by value, ref and out)

By value(default)

Passes a copy of the value. Changes don’t affect original.



By ref

Passes reference to the original variable. Value must be initialized before passing.

Modify existing values



By out

Similar to *ref* but used to return multiple values.

Value must be assigned in the method.

Variable doesn't need to be initialized before passing.

Return multiple values



Note:

\- Use ref when you're updating something.

\- Use out when you're producing something.





static vs instance method

When a method declaration includes a static modifier, that method is said to be a static method.

When no static modifier is present, the method is said to be an method.

Static method is invoked using the class name, where as an instance using an instance of the class

The difference between methods and static methods is that multiple instances of a class can be created (or instantiated) and each instance has own method. However, when a method is static, there are no instance of that method, and you can invoke only that one definition of the static method.



**Constructor and Destructor**



Constructor:



* Special method called when an object is created.
* Initializes object state.
* Can be overloaded.
* No return type.



Example:

public class Car {

    public Car() =>

        Console.WriteLine("Car object created.");

}



Types:

* Default Constructor
* Parameterized Constructor
* Static Constructor (called once for the type)





Destructor:

* Used to clean up resources before the object is destroyed.
* Only one destructor per class, no parameters or access modifiers.
* Called by the garbage collector.



Example:

~Car() {

    Console.WriteLine("Car object destroyed.");

}



Note: Avoid using destructors unless working with unmanaged resources. Prefer using ***IDisposable***.



Access Modifiers

Access modifiers control visibility of classes and members.



**Modifier		Accessible From						Used For**

public			Everywhere						Public APIs, reusable classes

private			Within the same class only				Hide internal details

protected		Class and derived (child) classes			Inheritance

internal		Same assembly (project)					Limit access within the same app

protected internal	Same assembly or derived class in another assembly	Hybrid access

private protected	Derived class in the same assembly			Restrictive hybrid

 



Optional \& Named Parameters

Optional Parameters
You can provide default values to parameters. If the caller doesn’t pass them, the default is used.


Example:
*public void Greet(string name = "Guest") {
Console.WriteLine($"Hello {name}");
}
Greet();        // Outputs: Hello Guest
Greet("Arun");  // Outputs: Hello Arun*



Named Parameters
Let you specify arguments by name, useful for readability or skipping optional ones



Example:

*public void Display(string name, int age = 25) { ... }*



*Display(age: 40, name: "Arun");*





























