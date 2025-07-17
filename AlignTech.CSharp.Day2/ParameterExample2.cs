namespace AlignTech.CSharp.Day2
{
    internal class ParameterExample2
    {
        //Optional Parameters Example
        public void GetData(string name, string companyName = "Align Tech")
        {
            Console.WriteLine($"Name : {name}, Company Name : {companyName}");
        }

        public static void Method()
        {
            Console.WriteLine("Static Method");
        }
    }
}
