using AlignTech.CSharp.Day8;
using System.Reflection;

#region Attribute Example

//AttributeExample obj = new AttributeExample();
////obj.Method1_V1();
////obj.Method1_V2();

//MySampleClass sample = new MySampleClass();

//////Read All the Properties
//Type type = typeof(MySampleClass);

//PropertyInfo[] properties = type.GetProperties();
//MethodInfo[] methods = type.GetMethods();

//Console.WriteLine($"Properties available in SampleClass");
//foreach (var item in properties)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine();
//Console.WriteLine($"Methods available in {nameof(MySampleClass)}");
//foreach (var item in methods)
//{
//    Console.WriteLine(item);
//}

////Creating Object Dynamically
//Console.WriteLine("\n Creating Object Dynamically\n");
////Create Dynamic Object
//var mySampleClass = Activator.CreateInstance(type);
//var add = type.GetMethod("AddNumber");
////var result = add?.Invoke(mySampleClass, new object[] { 5, 6 });
//var result = add?.Invoke(mySampleClass, [5, 6]);

//Console.WriteLine($"Add Result :{result}");

////Calling Method dynamically
//var greet = type.GetMethod("Greet", []);
//greet?.Invoke(mySampleClass, null);

////Get The Method - using typeof provide parameter type
//var greetMethod = type.GetMethod("Greet", [typeof(string)]);
////Calling the method
//greetMethod?.Invoke(mySampleClass, ["Kayal"]);

////Calling Greet Method with 2 Parameter
//var greetMethod2 = type.GetMethod("Greet", [typeof(string), typeof(long)]);
//greetMethod2?.Invoke(mySampleClass, ["Kayal", 7894561230]);

#endregion

//Custom Attribute
var attributes = typeof(Customer).GetCustomAttributes(true);

foreach(var attr in attributes)
{
    //Console.WriteLine(attr);
    if(attr is InfoAttribute info)
    {
        //  var info = (InfoAttribute)attr;
        Console.WriteLine($"Id :{info.Id}, Description :{info.Description}");
    }
}
