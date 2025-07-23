Action and Func delegates

Collection and Generics

Collection class

Generic and Non-generic collections

Generic collection(List<T>, Dictionary<TK,TV>)

Generic constraints

IEnumerable Interface



**Action Delegate**

Action is a built-in delegate type provided by the .NET framework. It represents a method that returns void and can take zero or more input parameters.



When to Use Action

* to store a reference to a method that does not return a value (void)
* to pass a method as a parameter
* doing functional or event-driven programming



Syntax:

*Action action = MethodName;*

*Action<int> action1 = MethodWithOneIntParam;*

*Action<int, string> action2 = MethodWithTwoParams;*



Note:

Supports up to 16 parameters





**Func<> Delegate**

Func<> is a built-in generic delegate that can encapsulate a method which returns a value.

&nbsp;Unlike Action<>, which returns void, Func<> must return a value (non-void).



Syntax:

*Func<ReturnType> funcName = Method;*

*Func<T1, TResult> funcName = Method;*

*Func<T1, T2, TResult> funcName = Method;*



When to Use Func<>

to reference a method that returns a value

to pass methods as arguments (e.g., in LINQ)

working with functional programming concepts



Note:

Supports up to 16 parameters



**Collections in C#**

Collections are data structures that store and manage groups of related objects.

They offer more flexibility than arrays and are categorized into generic, non-generic



Non-Generic Collections

Non-generic collections are part of the ***System.Collections*** namespace and store elements as object type.

This means they can hold mixed data types, but lack compile-time type safety, leading to potential runtime errors due to casting and boxing/unboxing.



Key Characteristics

\- Type flexibility: Can store any type of object.

\- No type safety: Type mismatches are caught only at runtime.

\- Boxing/unboxing overhead: Value types are boxed when added and unboxed when retrieved.

\- Legacy support: Useful when working with older .NET codebases.





Common Non-Generic Collections

\- ArrayList: Resizable array that stores elements as object.

\- Hashtable: Stores key-value pairs using hash codes; keys must be unique.

\- Queue: FIFO structure

\- Stack: LIFO structure



When to Use Non-Generic Collections

\- Interacting with legacy systems or older .NET libraries.

\- When type flexibility is more important than safety.

\- For quick prototyping without enforcing strict types.



Example:

ArrayList list = new ArrayList();

Hashtable table = new Hashtable();



Note:

Non-generic collections lack compile-time type safety and require casting.



What Are Generic Collections?

Generic collections are type-safe, reusable data structures defined in the System.Collections.Generic namespace.

They allow you to specify the data type at compile time, eliminating the need for casting and reducing runtime errors.



Why Generic Collections?

\- Type Safety: Prevents type mismatches at compile time.

\- Performance: Avoids boxing/unboxing for value types.

\- Reusability: Works with any data type.

\- Cleaner Code: No need for explicit casting



Common Generic Collection Type



* List<T>: Dynamic array with index-based access.
* Dictionary<Tkey, Tvalue>: Key-value pairs with fast lookup.
* Queue<T>: FIFO structure for ordered processing
* Stack<T>: LIFO structure for ordered processing
* HashSet<T>: Unordered collection of unique elements
* SortedList<TKey, TValue>: Sorted key-value pairs based on keys



Example:List<T>

List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

foreach (var fruit in fruits)

    Console.WriteLine(fruit);



Generic Constraints

You can restrict the types used with generics. They enhance type safety and allow for more specific operations within generic code.



public class Repository<T> where T : class {

    // T must be a reference type

}

Other constraints:

\- where T : struct → value type

\- where T : new() → must have a parameterless constructor

\- where T : BaseClass → must inherit from a specific class

\- where T : InterfaceName → must implement an interface



**IEnumerable Interface**



IEnumerable is an interface that enables iteration over a collection using a foreach loop. It’s the base interface for all non-generic and generic collections in C#.



Syntax:

public interface IEnumerable {

&nbsp;   IEnumerator GetEnumerator();

}



\- Found in System.Collections (non-generic) and System.Collections.Generic (generic as IEnumerable<T>)

\- Returns an IEnumerator which exposes MoveNext(), Reset(), and Current

\- List<T> implements IEnumerable<T>, so it can be looped using foreach

\- Enables read-only traversal of elements















































