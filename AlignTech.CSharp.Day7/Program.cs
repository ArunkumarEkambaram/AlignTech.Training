using AlignTech.CSharp.Day7;
using AlignTech.CSharp.Day7.Models;
using System.Collections;

#region NonGeneric
//NonGenericCollection obj = new NonGenericCollection();
////obj.TestMethod();

////obj.AddDetails();

////obj.HashTableDemo();

////Stack -- LIFO
//Stack stack = new Stack();
//stack.Push(100);
//stack.Push(600);
//stack.Push(5);
//stack.Push(-100);

//Console.WriteLine($"Last Value :{stack.Pop()}");

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}

////Collection Initializer
//ArrayList list = new ArrayList()
//{
//    100, true, 5000
//};

#endregion

#region CRUD using List

//GenericDemo generic = new GenericDemo();
////generic.TestMethod();
////generic.TestMethod2();

////CRUD
//Cart cart = new Cart();
////Add Product
//cart.AddToCart(new Product { ProductId = 1001, ProductName = "Pencil", Price = 50 });
//cart.AddToCart(new Product { ProductId = 1002, ProductName = "Tennis Ball", Price = 5000 });
//cart.AddToCart(new Product { ProductId = 1003, ProductName = "Cricket Ball", Price = 600 });

////Get All Product
//cart.DisplayProductInCart();

////Remove from cart
//Console.Write("Enter Product Id to Remove from Cart :");
//int id = int.Parse(Console.ReadLine());
//cart.RemoveFromCart(id);

//cart.DisplayProductInCart();
////Update Product
//Product updatedProduct = new()
//{
//    ProductId = 1001,
//    ProductName = "Laptop",
//    Price = 50000
//};

//cart.UpdateProduct(updatedProduct);

//cart.DisplayProductInCart();

#endregion


#region Dictionary

////Dictionary Example
//DictionaryExample obj = new();
////obj.AddScores();

//obj.AddUserProfiles();

#endregion

//MyCollection obj = new AlignTech.CSharp.Day7.MyCollection();
MyCollection<Product> myProducts = new MyCollection<Product>();
myProducts.Add(new Product { ProductId = 1001, ProductName = "Pencil", Price = 50 });
myProducts.Add(new Product { ProductId = 1002, ProductName = "Router", Price = 1499 });
myProducts.Add(new Product { ProductId = 1003, ProductName = "Water Bottle", Price = 299 });

foreach(var prd in myProducts)
{
    Console.WriteLine($"Product Id :{prd.ProductId}\tProduct Name :{prd.ProductName}");
}

