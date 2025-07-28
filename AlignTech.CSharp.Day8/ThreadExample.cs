namespace AlignTech.CSharp.Day9
{
    internal class ThreadExample
    {
        static int counter = 0;
        public void Process()
        {
            Thread t1 = new Thread(Increment);
            t1.Start();
        }

        static void Increment()
        {
            for (int i = 0; i < 10; i++)
            {
                counter++;
                Console.WriteLine($"Counter :{counter}");
            }
        }
    }
}
