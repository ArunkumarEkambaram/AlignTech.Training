using AlignTech.CSharp.Day6;

#region MyRegion

//DelegateExample obj = new DelegateExample();

////Step 2: Assign or Reference a method
//MyDelegate del = obj.Message;

////Step 3: Call or Use Delegate
//del("Pradeep");

//MultiCast Delegate
//var log = new LogError();

//MyDelegate logError = null;
//Console.WriteLine("Enter True / False");
//bool status = bool.Parse(Console.ReadLine());
//if (status)
//{
//    logError = log.LogToFile;
//    logError += log.LogToConsole;
//    logError += log.LogToConsole;

//    logError += LogError.StaticMethod;

//    //logError += LogError.StaticMethod1;
//    logError -= log.LogToConsole;

//    logError("New Exception arised");
//}
//else
//{
//    logError = log.LogToFile;
//    logError("New Exception arised");
//}

////Calculate Delegate
//Calculate.CalcEventHandler calcDel = null;
//calcDel += new Calculate().AddNumber;

//var res1 = calcDel(5, 20);

//calcDel += new Calculate().Multiply;

//var res = calcDel(5, 6);

//Console.WriteLine($"Result :{res}");
//Console.WriteLine($"Result 1:{res1}");

////Anonymous Method

//calcDel = delegate (int a, int b)
//{
//    return a / b;
//};

//Console.WriteLine($"Divide :{calcDel(20, 5)}");

////Lambda Expression 

//calcDel = (a, b) =>
//{
//    return a - b;
//};
//Console.WriteLine($"Subtract  :{calcDel(20, 5)}");


#endregion

#region Delegate

////Action
//DelegateEx2 obj = new DelegateEx2();
//Action greet = obj.Greet;
////greet("Kayal");
//greet();

//Action<string> greet1 = obj.Greet;
//greet1("Hari");

////Action<int, int> divide = obj.Divide;
////var result = divide(200, 6);
////Console.WriteLine(result);

//Func<int, int, float> divide = obj.Divide;
//var result = divide(200, 3);
//Console.WriteLine($"Divide :{result.ToString("n2")}");

//Func<int, int, string> multi = (a, b) => (a * b).ToString();
//Console.WriteLine($"Multiply :{multi(50, 6)}");

////Calling Method using Predicate
//Predicate<int> find = obj.FindById;
//Console.WriteLine(find(11) ? "Employee Id Found" : "Invalid Id");
#endregion

//Event
Alarm alarm = new Alarm();
User user = new User();

alarm.RaiseAlarm += user.Message;
alarm.RaiseEvent("Wake Up, Good Morning");