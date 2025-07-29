//LINQ
using AlignTech.LINQ.Day10.Models;

var productData = new Product().GetProducts();
var categoryData = new Category().GetCategories();
//categoryData.Add(new Category { Id = 4 });

//Query Expresssion
var productQuery = from p in productData
                   where p.Price > 1000 && p.Name.Contains("p", StringComparison.OrdinalIgnoreCase)
                   select p;

//Console.WriteLine("Query Expresssion");
//foreach (var prd in productQuery)
//{
//    Console.WriteLine($"Product Id :{prd.Id}\tProduct Name :{prd.Name}\tPrice :{prd.Price}");
//}
//Console.WriteLine();

//Lambda 
//var productLambda = productData
//                                     //.Where(p => p.Price > 1000 && p.Name.Contains("p", StringComparison.OrdinalIgnoreCase))
//                                     //.Select(p => p.Name);
//                                     //.OrderBy(p => p.Name)//Ascending Order
//                                     //.OrderBy(p => p.Name).ThenBy(p => p.Price)
//                                     //.OrderByDescending(p => p.Price).ThenBy(c => c.Price) //Descending Order
//                                     .OrderByDescending(p => p.Price)
//                                     .Select(p => new
//                                     {
//                                         ProductId = p.Id,
//                                         ProductName = p.Name,
//                                         ProductPrice = p.Price
//                                     })
//                                    // .Distinct();
//                                    // .DistinctBy(p => p.ProductName);
//                                    //.Take(3);
//                                    // .Skip(3);
//                                    ;

//Console.WriteLine("Lambda Expresssion");
//foreach (var prd in productLambda)
//{
//    //Console.WriteLine($"Product Id :{prd.Id}\tProduct Name :{prd.Name}\tPrice :{prd.Price}");
//    //Console.WriteLine(prd);
//    Console.WriteLine($"Product Id :{prd.ProductId}\tProduct Name :{prd.ProductName}\t Price :{prd.ProductPrice}");
//}


////First / FirstOrDefault and Single / SingleOrDefault
//var productLambda = productData.Where(x => x.Id == 1);
//var product = productData.First(x => x.Id == 11);
//var product = productData.FirstOrDefault(x => x.CategoryId == 1); //Useful for Primary Key and Non-Primary Key
//var product = productData.SingleOrDefault(x => x.CategoryId == 1);//Useful for Primary Key
//if (product != null)
//{
//    Console.WriteLine($"Product Id :{product.Id}\tProduct Name :{product.Name}\tPrice :{product.Price}");
//}
//else
//{
//    Console.WriteLine("Product Id didn't exist");
//}

////Group By
//var productGroup = productData.GroupBy(p => p.CategoryId);

//foreach (var group in productGroup)
//{
//    //Console.WriteLine($"Category Id :{group.Key}\tNo.Of Products:{group.Count()}");
//    //Console.WriteLine($"Category Id :{group.Key}");
//    //foreach(var item in group)
//    //{
//    //    Console.WriteLine($"Product Id :{item.Id}\tName :{item.Name}");
//    //}

//    Console.WriteLine($"Category Id :{group.Key}\t{string.Join(", ", group.Select(p => p.Name))}");
//}

//Join
var productJoin = productData.Join(
                               categoryData,
                               p => p.CategoryId, //Outer Table Key
                               c => c.Id, //Inner Table Key
                               (p, c) => new
                               {
                                   ProductId = p.Id,
                                   CategoryId = p.CategoryId,
                                   CategoryName = c.CategoryName,
                                   ProductName = p.Name,
                                   Price = p.Price,
                               }
                               );
foreach(var item in productJoin)
{
    Console.WriteLine($"PRoduct Name {item.ProductName}\tCategory Name :{item.CategoryName}\tPRice :{item.Price}");
}