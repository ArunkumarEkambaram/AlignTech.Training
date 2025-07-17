namespace AlignTech.CSharp.Day2
{
    internal partial class Employee
    {
        public int id;
        public string name;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();
        }
    }
}
