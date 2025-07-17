using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlignTech.CSharp.Day2
{
    public class StaticExample
    {
        static int id = 10001;
        string name;

        ////Default Constructor
        public StaticExample()
        {
            Console.WriteLine("Default Constructor");
            id = 10001;
        }

        public StaticExample(string name)
        {
            this.name = name;
        }

        static StaticExample()
        {
            id = 2000;
            Console.WriteLine("Static Constructor");
        }

        public void GetId()
        {
            Console.WriteLine($"Id : {id}");
        }   
    }
}
