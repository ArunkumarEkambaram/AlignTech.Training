using AlignTech.CSharp.Day4;

#region Property Example
//Customer customer = new Customer();
//customer.FirstName = "";
////customer.Price = 0;
//customer.Age = 500;

////customer.Salary = 500;
////customer.Shipping = 500;

////Object Initializer
//Customer customer2 = new Customer
//{
//    FirstName = "Pradeep",
//    Age = 20,
//    Price = 500,
//    Shipping = 60,
//};

//customer.LogMessage = "Error has been logged successfully";
////Console.WriteLine(customer.LogMessage);

//Console.WriteLine($"Computed Property :{customer2.Total}");


#endregion


#region Exception Handling

//Exception Handling
ExceptionExample obj = new ExceptionExample();
//try
//{
//    obj.TestMethod();
//}
//catch(Exception ex)
//{
//    Console.WriteLine("Main Method :"+ex.Message);
//}
//obj.TestMethod();

//int[] arr = new int[3];
//try
//{
//    arr[3] = 100;
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.ToString());
//}
//finally //Resource clean up
//{
//    Console.WriteLine("Finally Block");
//}

//Calling Testmethod2
//try
//{
//    obj.TestMethod2();
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

//Understanding use of throw keyword
//try
//{
//    obj.ProcessUserData();
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

#endregion

string str = "Hello, World. Good Morning        Hello";

int result = str.WordCount();
Console.WriteLine($"Result :{result}");

ExceptionExample exp1=new ExceptionExample();
exp1.GetAllException("Base Exception");