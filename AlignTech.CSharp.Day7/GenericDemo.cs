using AlignTech.CSharp.Day7.Models;
using System.Collections.Generic;


namespace AlignTech.CSharp.Day7
{
    /*
     * List
     * SortedList
     * Stack
     * Queue
     * DictionaryList
     */
    public  class GenericDemo
    {
        List<int> list = new List<int>();     
        
        public void TestMethod()
        {
            list.Add(1);
            list.Add(5000);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }

        public void TestMethod2()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = 1001, ProductName = "Pencil" });
            products.Add(new Product { ProductId = 1002, ProductName = "IPad" });
            products.Add(new Product { ProductId = 1003, ProductName = "Mobile Phone" });
            //products.Add(new Employee { EmpId = 100 });

            foreach(var prd in products)
            {
                Console.WriteLine($"Product Id :{prd.ProductId}, Product Name :{prd.ProductName}");
            }
        }
    }
}
