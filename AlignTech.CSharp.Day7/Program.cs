using AlignTech.CSharp.Day7;
using System.Collections;

NonGenericCollection obj = new NonGenericCollection();
//obj.TestMethod();

//obj.AddDetails();

//obj.HashTableDemo();

//Stack -- LIFO
Stack stack = new Stack();
stack.Push(100);
stack.Push(600);
stack.Push(5);
stack.Push(-100);

Console.WriteLine($"Last Value :{stack.Pop()}");

foreach (var item in stack)
{
    Console.WriteLine(item);
}

//Collection Initializer
ArrayList list = new ArrayList()
{
    100, true, 5000
};