namespace AlignTech.CSharp.Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class
            //Partial Class Example
            //Employee employee = new Employee();
            //employee.GetEmployeeDetails();
            //employee.Display();
            #endregion

            #region Parameter Example   
            //Parameter Example
            //int n1 = 10, n2 = 30, result;
            //MethodParamter obj = new MethodParamter();
            //obj.SumNumbers(n1, n2, out result);
            //Console.WriteLine($"Result :{result}");
            #endregion

            #region Optional Parameters
            ////Parmeter Example 2
            //ParameterExample2 obj = new ParameterExample2();
            //obj.GetData("John Doe");
            //obj.GetData("Jane Doe", "Tech Corp");

            ////Named Parameters Example
            //obj.GetData(companyName: "Capgemini", name: "Alice Smith");
            #endregion

            #region StaticExample


            ////Static Method Example
            //ParameterExample2.Method();
            //StaticExample user2 = new StaticExample("John Doe");//Parameterized Constructor

            StaticExample user1 = new StaticExample();//Default Constructor
            user1.GetId(); // Calls the static constructor and prints the id

            StaticExample user2 = new StaticExample();//Default Constructor
            user2.GetId(); // Calls the static constructor and prints the id
            #endregion

            AccessModifier obj = new AccessModifier();
            obj.name = "John Doe"; // Accessing public member
            obj.age = 200;
            obj.salary = 50000; // Accessing protected member
            obj.companyName = "Align Tech"; // Accessing internal member
        }
    }
}
