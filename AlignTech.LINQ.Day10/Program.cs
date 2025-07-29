//LINQ
using AlignTech.LINQ.Day10.Models;

var productData = new Product().GetProducts();
var categoryData = new Category().GetCategories();
//categoryData.Add(new Category { Id = 4 });

//Query Expresssion
var productQuery = from p in productData
               where p.Price > 1000 && p.Name.Contains("p", StringComparison.OrdinalIgnoreCase)
               select p;

Console.WriteLine("Query Expresssion");
foreach (var prd in productQuery)
{
    Console.WriteLine($"Product Id :{prd.Id}\tProduct Name :{prd.Name}\tPrice :{prd.Price}");
}
Console.WriteLine();

//Lambda 
var productLambda = productData
                                     .Where(p => p.Price > 1000)
                                     .Where(x => x.Name.Contains("p", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Lambda Expresssion");
foreach (var prd in productLambda)
{
    Console.WriteLine($"Product Id :{prd.Id}\tProduct Name :{prd.Name}\tPrice :{prd.Price}");
}
