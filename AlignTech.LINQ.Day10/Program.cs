//LINQ
using AlignTech.LINQ.Day10.Models;

var productData = new Product().GetProducts();
var categoryData = new Category().GetCategories();
//categoryData.Add(new Category { Id = 4 });

//Query Expresssion
var product = from p in productData 
                        select p;


//Lambda 