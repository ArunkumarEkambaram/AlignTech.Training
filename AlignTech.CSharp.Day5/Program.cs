//Implicit Typed Variables
using AlignTech.CSharp.Day5;

////COmpile Time
//var obj = new Example1();

//var x = 30;

//var y = "Hello";

////x = "World";

////Dynamic - Runtime
//dynamic d1 = new Example1();

////d1 = "Hello World";

////d1 = true;

////obj.TestMethod();

//d1.TestMethod();

////Dynmaic Variables
//dynamic value = "Hello";
//d1.DynamicMethod(value);

//int n1 = 123456;

//d1.DynamicMethod(n1);

//var ex = new Example1 { MyProperty = 100 }; //Object Initializer

////d1.DynamicMethod(ex);

////Anonymous Types
//var customer = new
//{
//    Id = 1001,
//    Name = "Aravind",
//    Age = 50,
//    MobileNo = "7894561230",
//    Salary = 5000.5m,
//    Address = new { HomeAddress = "Home Address", OfficeAddress = "Office Addres" }
//};

//Console.WriteLine($"Customer Details\n");
//Console.WriteLine($"ID :{customer.Id}\nName :{customer.Name}\nSalary :{customer.Salary}");
//Console.WriteLine($"Address :{customer.Address.OfficeAddress}");

//Enum Example
Console.WriteLine($"Enum Example");
Console.WriteLine($"Status :{Example1.Status.Approved}");
Console.WriteLine($"Status :{(int)Example1.Status.Approved}");

//Enum Example
Console.WriteLine($"Line 57: Permissions :{Permissions.All}");
Console.WriteLine($"Permissions :{Convert.ToInt32(Permissions.All)}");

Permissions permissions = Permissions.Read | Permissions.Write;

Console.WriteLine($"Line 62: Permissions :{permissions}");

// 0 - 0000