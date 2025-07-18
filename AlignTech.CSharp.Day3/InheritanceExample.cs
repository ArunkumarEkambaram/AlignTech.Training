using static System.Console;


namespace AlignTech.CSharp.Day3
{
    //IS-A Relationship Example
    public class ParentClass
    {
        //public ParentClass()
        //{
        //    WriteLine($"Parent Class Constructor");
        //}

        public ParentClass(int i)
        {
            WriteLine($"Parent Class Constructor : {i}");
        }

        public ParentClass(string i)
        {
            WriteLine($"Parent Class Constructor : {i}");
        }
    }

    public class ChildClass : ParentClass
    {
        //public ChildClass() : base(100)
        //{           
        //    WriteLine($"Child Class Constructor");
        //}

        public ChildClass(string i) :base(100)
        {
            WriteLine($"Child Class Constructor :{i}");
        }
    }
}
