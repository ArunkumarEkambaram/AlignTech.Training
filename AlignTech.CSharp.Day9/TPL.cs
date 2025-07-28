namespace AlignTech.CSharp.Day9
{
    internal class TPL
    {
        public void Method1()
        {
            throw new Exception("Error occurred");
            Parallel.For(0, 10, (i) =>
            {
                Console.WriteLine($"Value :{i}\tThread Id :{Task.CurrentId}");
            });
        }

        public void Method2()
        {
            List<string> cities = ["Chennai", "Mumbai", "Delhi", "Bengaluru", "Hyderabad"];
            Parallel.ForEach(cities, i => Console.WriteLine($"Value :{i}\tThread Id :{Task.CurrentId}"));
        }

        public void Method3(string x)
        {
            Console.WriteLine("This is Method 3"+x);
        }
    }
}