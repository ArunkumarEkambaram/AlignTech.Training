using System.Collections;
using System.Security.AccessControl;

namespace AlignTech.CSharp.Day7
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }

    public class NonGenericCollection
    {
        ArrayList arrList = new ArrayList();
        public void TestMethod()
        {
            arrList.Add(100);
            arrList.Add("Hello");
            arrList.Add(true);

            foreach (object item in arrList)
            {
                Console.WriteLine(item);
            }
        }

        public void AddDetails()
        {
            arrList.Add(new Product { ProductId = 1, ProductName = "Pen" });
            arrList.Add(new Product { ProductId = 2, ProductName = "Ball" });
            arrList.Add(new Product { ProductId = 3, ProductName = "Tennis Ball" });
            arrList.Add(100);
            arrList.Add(300);            

            if (arrList.Contains(100))
            {
                arrList.Remove(100);
            }

            foreach (object item in arrList)
            {
                if (item is Product prd)
                {
                    // Product prd = (Product)item;
                    Console.WriteLine($"Product Id :{prd.ProductId}, ProductName :{prd.ProductName}");
                }
                else if (item is int)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //Hashtable
        public void HashTableDemo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, new Employee { EmpId = 1, EmpName = "Jagan" });
            ht.Add(2, 1000);
            ht.Add("1", 5000);

            if (ht.ContainsKey(2))
            {
                ht.Remove(2);
            }

            foreach (DictionaryEntry item in ht)
            {
                if (item.Value is Employee emp)
                {
                    Console.WriteLine($"Emp ID :{emp.EmpId}, EmpName :{emp.EmpName}");
                }
                else
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
