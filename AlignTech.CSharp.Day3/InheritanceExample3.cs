namespace AlignTech.CSharp.Day3
{
    public class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("BaseClass Display");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Display() // Hides the base class method
        {          
            Console.WriteLine("DerivedClass Display");
        }
    }
}
