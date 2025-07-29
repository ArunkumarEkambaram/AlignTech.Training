using AlignTech.CSharp.Day9;
using Microsoft.Extensions.DependencyInjection;

#region Thread

//ThreadExample obj=new ThreadExample();
//obj.Process();

//TPL obj = new TPL();
//obj.Method1();
//Console.WriteLine();
//obj.Method2();


//try
//{
//    Parallel.Invoke(
//        () => obj.Method1(),
//        () => obj.Method2(),
//        () => obj.Method3("Hello")
//        );
//}
//catch (AggregateException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Async Programming
//AsyncExample asyncEx = new AsyncExample();

//Task<string> content = asyncEx.DownloadAsync();

//Console.WriteLine($"Total Length :{(await content).Length}");

//FileHandling files = new FileHandling();
//string path = @"D:\2025\AlignTech\Topics.txt";
////files.FetchAndDisplayData(path);
//await files.FetchAndDisplayDataAsync(path);

#endregion

//Microsoft.Extensions.DependencyInjection

//ProductBL product = new(new ProductDALV2());
//product.GetProduct();

//Resolve DI

//var service = new ServiceCollection().AddSingleton<IProduct, ProductDAL>();
//var provider = service.BuildServiceProvider();

//var service = new ServiceCollection().AddSingleton<IProduct, ProductDAL>().BuildServiceProvider();

//Constructor Injection
//ProductBL product = new ProductBL(provider.GetService<IProduct>());
//product.GetProduct();

////Method Injection
//AnotherClassBL anotherClassBL = new AnotherClassBL();
//anotherClassBL.GetProduct(provider.GetService<IProduct>());

////Property Injection
//AnotherClassBL anotherClassBL = new AnotherClassBL();
//anotherClassBL.ProductDataObject = provider.GetService<IProduct>();
//anotherClassBL.GetProductByProperty();
