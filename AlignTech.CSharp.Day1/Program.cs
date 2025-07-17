//using AlignTech.CSharp.MyNamespace;
//using Microsoft.VisualBasic;

//int a = 100; //Value Type
//short age = 100;

//float salary = 100.40F;
//decimal price = 5555.68M;

//string str = "Hello"; //Reference Type

////Console.WriteLine($"Integer :{a}\nString :{str}");

////Boxing - Converting Value type to Reference Type
////Implicit Boxing
//object obj = age;
//obj = salary;

////Explicit Boxing
//string s1 = age.ToString();
//s1= price.ToString();

//Console.WriteLine($"Boxing :{obj}");

////UnBoxing - Converting Referecne type to Value type (Conversion Method, Parse Method)
//// Type Conversion  Conversion Method, Parse, Type casting
//string s2 = "1000";
//object obj3 = 5000;

//s2 = obj3.ToString();

////int x = obj3;

////int z = s2;

////Conversion method

//int getFromObject = Convert.ToInt32(obj3);
//int getFromString = Convert.ToInt32(s2);

//Console.WriteLine("Enter a Gender (M/F) :");
////char gender = Convert.ToChar(Console.ReadLine());
////char gender = char.Parse(Console.ReadLine());

////Console.WriteLine($"You have choosen :{gender}");

//int parseMethod = int.Parse(s2);

////Type Casting - Converting  Higher Value type to Lower Value  Type  or Higher Reference  TYpe to Lower Reference Type

//int data1 = 100;
//long longType = 100000;

//float data2 = 200.5f;

////longType = data1;

//data1 =(int)longType;// Type casting

////data1 = Convert.ToInt32(longType);

//Console.WriteLine($"Long :{longType}\tInt :{data1}");

//DateTime dt = new DateTime(2025, 12, 31);
//dt = Convert.ToDateTime(Console.ReadLine());
//dt = DateTime.Parse(Console.ReadLine());

// Parse
//Console.WriteLine("Enter a Number :");
//int parseMethod = int.Parse(Console.ReadLine());
//Console.WriteLine($"Number :{parseMethod}");

////Try Parse
//Console.WriteLine("Enter a Number :");
//int.TryParse(Console.ReadLine(), out int number);
//Console.WriteLine($"Number :{number}");

////Instance Example
//using AlignTech.CSharp.Day1;

//Sample2 obj = new();
//obj.id = 100;

//Sample2 obj2 = new Sample2();
//obj.id = 200;

////Static Example
//Sample2.name = "AlignTech";

////obj.salary = 2000;

////Const Variable
//Console.WriteLine($"Company Name :{Sample2.company}");

//Calling New Class
using AlignTech.CSharp.Day1;

NewClass obj = new NewClass();
obj.GetData();