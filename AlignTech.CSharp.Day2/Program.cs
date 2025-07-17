namespace AlignTech.CSharp.Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Partial Class Example
            //Employee employee = new Employee();
            //employee.GetEmployeeDetails();
            //employee.Display();

            //Parameter Example
            //int n1 = 10, n2 = 30, result;
            //MethodParamter obj = new MethodParamter();
            //obj.SumNumbers(n1, n2, out result);
            //Console.WriteLine($"Result :{result}");

            ////Parmeter Example 2
            //ParameterExample2 obj = new ParameterExample2();
            //obj.GetData("John Doe");
            //obj.GetData("Jane Doe", "Tech Corp");

            ////Named Parameters Example
            //obj.GetData(companyName: "Capgemini", name: "Alice Smith");

            ////Static Method Example
            //ParameterExample2.Method();

            StaticExample obj = new StaticExample();//Default Constructor
            StaticExample obj2= new StaticExample("John Doe");//Parameterized Constructor

            obj.GetId(); // Calls the static constructor and prints the id
        }
    }
}
