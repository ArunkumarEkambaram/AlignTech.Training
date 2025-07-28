namespace AlignTech.CSharp.Day9
{
    internal class ThreadExample
    {
        static int counter = 0;
        static readonly object objLock = new object();
        public void Process()
        {
            Thread t1 = new Thread(Increment);           
            Thread t2 = new Thread(Increment);           

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Total Counter :{counter}");
        }

        static void Increment()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (objLock)
                {
                    counter++;
                }
                Console.WriteLine($"Counter :{counter}\t Thread Id :{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);
            }
        }
    }
}
