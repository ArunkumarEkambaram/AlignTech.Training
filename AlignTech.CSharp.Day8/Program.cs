using AlignTech.CSharp.Day8;
using System.Reflection;

AttributeExample obj = new AttributeExample();
//obj.Method1_V1();
//obj.Method1_V2();

MySampleClass sample = new MySampleClass();

//Read All the Properties
Type type = typeof(MySampleClass);

PropertyInfo[] properties = type.GetProperties();
MethodInfo[] methods = type.GetMethods();

Console.WriteLine($"Properties available in SampleClass");
foreach (var item in properties)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine($"Methods available in {nameof(MySampleClass)}");
foreach (var item in methods)
{
    Console.WriteLine(item);
}

