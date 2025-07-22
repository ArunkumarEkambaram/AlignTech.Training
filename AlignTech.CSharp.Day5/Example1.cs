namespace AlignTech.CSharp.Day5
{
   
    /*
     * */
    internal class Example1
    {
        public int MyProperty { get; set; }
        public void TestMethod()
        {
            Console.WriteLine("Test Method");
        }

        public void DynamicMethod(dynamic d)
        {
            Console.WriteLine($"Type :{d.GetType()}\tValue :{d}");
        }

        //Enum - Public, Private or Internal
        //Value type
        //Type: byte, int, short, long
        public enum Status : byte
        {
            Pending = 101,
            Rejected = 103,
            Approved = 255
        }
    }

    [Flags]
    //Bitwise Operator - [Flag] attribute, distinct power of 2 for all enum values
    enum Permissions
    {
        None = 2,
        Read = 4,
        Write = 8,
        Archieve = 16,
        All = Read | Write | Archieve
    }

}
