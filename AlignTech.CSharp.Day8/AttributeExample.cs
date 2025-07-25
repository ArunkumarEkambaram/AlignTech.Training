namespace AlignTech.CSharp.Day8
{
    public class AttributeExample
    {
        //Pre Defined Attribute

        [Obsolete("This method is old, use new method", true)]
        public void Method1_V1()
        {
            Console.WriteLine("This is Method 1 Version 1");
        }

        public void Method1_V2()
        {
            Console.WriteLine("This is Method 1 Version 2");
        }
    }

    public class MySampleClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Greet(string name)
        {
            Console.WriteLine($"Welcome, {name}");
        }

        public int AddNumber(int a, int b) => a + b;
    }
}
