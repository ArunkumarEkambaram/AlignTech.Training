﻿namespace AlignTech.CSharp.Day8
{
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    // [AttributeUsage(AttributeTargets.Class)]
    public class InfoAttribute : Attribute
    {
        public int Id { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// When implementing attribute, Status is optional parameter, Use. Status=""
        /// </summary>      
        public string Status { get; set; }

        public InfoAttribute(int id)
        {
            Id = id;
        }

        public InfoAttribute(int id, string description)
        {
            Id = id;
            Description = description;
        }

    }

    //If AllowMultiple = True, you can create one or more instance of Attribute on the top of Class or any
    [Info(1006, Description = "Desc")]
    [Info(1001, "This is class is used to fetch record from database", Status = "Rejected")]
    public class Customer
    {
        [Info(1002, "This is class is used to fetch record from database")]
        public void TestMethod()
        {

        }

        // [Info(1002, "This is class is used to fetch record from database")]
        public int MyProperty { get; set; }

    }

    public class ChildClass : Customer
    {

    }
}
