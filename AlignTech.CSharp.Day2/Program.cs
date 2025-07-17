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
            int n1 = 10, n2 = 30, result;
            MethodParamter obj = new MethodParamter();
            obj.SumNumbers(n1, n2, out result);
            Console.WriteLine($"Result :{result}");
        }
    }
}
