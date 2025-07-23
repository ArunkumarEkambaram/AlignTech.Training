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
}
