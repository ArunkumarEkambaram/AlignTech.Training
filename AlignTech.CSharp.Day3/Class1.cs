using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlignTech.CSharp.Day3
{
    public abstract class Class1
    {
        public abstract void Method1();
    }

    public abstract class Class2 : Class1
    {
        public abstract void Method2();
    }

    public class Class3 : Class2
    {
        public override void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public sealed override void Method1()
        {
            Console.WriteLine("Method 2");
        }
    }

    public class  Class4: Class3
    {
        //Since the method is sealed in Class3, it cannot be overridden here.
        //public override void Method1()
        //{
        //    base.Method1();
        //}

        public override void Method2()
        {
            base.Method2();
        }
    }
}
