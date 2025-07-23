namespace AlignTech.CSharp.Day6
{
    //Create a Delegate - Step 1
    public delegate void MyDelegate(string msg);   

    public class DelegateExample
    {
        public void Message(string name)
        {
            Console.WriteLine($"Welcome, {name}");
        }
    }

    //Multicast Delegate
    public class LogError
    {
        public void LogToFile(string msg)
        {
            Console.WriteLine($"Error logged in Files : {msg}");
        }

        public void LogToConsole(string msg)
        {
            Console.WriteLine($"Error logged in Console :{msg}");
        }

        public static void StaticMethod(string  msg)
        {
            Console.WriteLine(msg);
        }

        public static void StaticMethod1(string msg, string ex1)
        {
            Console.WriteLine(msg);
        }
    }
}
