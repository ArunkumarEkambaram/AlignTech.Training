using Microsoft.VisualBasic;

namespace AlignTech.CSharp.Day6
{
    //Create a Delegate
    public delegate void RaiseAlarmEventHandler(string msg);

    //Publisher Class
    public class Alarm
    {
        //Create a Event based on Delegate
        public event RaiseAlarmEventHandler RaiseAlarm;

        public void RaiseEvent(string msg)
        {
            RaiseAlarm?.Invoke(msg);
            //RaiseAlarm(msg);
        }

    }

    //Subscriber Class
    public class User
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class TestClass
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public void Method1()
        {
            Console.WriteLine($"Enter User Id and Password");
            UserId = Console.ReadLine();
            Password = Console.ReadLine();
        }

        public void Method2(string uid, string pwd)
        {
            UserId = uid;
            Password = pwd;
        }
    }

    //Callback

    public delegate void NotificationHandler(string msg);
    public class CallbackExample
    {
        public void AddNumber(int a, int b, NotificationHandler callback)
        {
            int result = a + b;
            callback($"Addition Result :{result}");
        }

        public void MultiNumber(int a, int b, NotificationHandler callback)
        {
            int result = a * b;
            callback($"Multi Result :{result}");
        }
    }

    public class Notify
    {
        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
