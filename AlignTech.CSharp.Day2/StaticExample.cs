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
        static int id; //Declare a static variable
        string name;

        ////Default Constructor
        public StaticExample()
        {
            //  Console.WriteLine("Default Constructor");
            id++; // Increment the static variable          
        }

        public StaticExample(string name)
        {
            this.name = name;
        }

        static StaticExample()
        {
            id = 1000; //Initialize the static variable
            //Console.WriteLine("Static Constructor");
        }

        public void GetId()
        {
            Console.WriteLine($"Id : {id}");
        }

        ~StaticExample()
        {
            // Destructor
            Console.WriteLine("Destructor called");
        }
    }
}
