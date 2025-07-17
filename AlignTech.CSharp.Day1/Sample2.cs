namespace AlignTech.CSharp.Day1
{
    internal class Sample2
    {
       public int id; //Instance variable
       public static string name; //static variable
        public readonly decimal salary = 1000.50M; //readonly variable
        public const string company = "AlignTech"; //const variable

        public Sample2()
        {
            salary = 66000.55m;
           // company = "HCL";
        }

        public void GetData()
        {
           // company = "Cognizant";
            id = 1000;
          //  salary = 2000.75M;
            Console.WriteLine($"Salary :{salary}");
        }
    }
}
