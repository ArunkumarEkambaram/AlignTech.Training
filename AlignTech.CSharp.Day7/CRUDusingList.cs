using AlignTech.CSharp.Day7.Models;
using System.Collections.Generic;


namespace AlignTech.CSharp.Day7
{
    public class Cart
    {

        List<Product> productList;

        public Cart()
        {
            this.productList = new List<Product>();
        }

        //Add Product
        public void AddToCart(Product product)
        {
            productList.Add(product);
        }

        public void DisplayProductInCart()
        {
            //productList.Sort(new PriceComparer());
            productList.Sort((x, y) => { return y.Price.CompareTo(x.Price); });

            //var products = productList.OrderByDescending(x => x.ProductName).ToList();
            Console.WriteLine($"{"Product Id",-10}\t{"Product Name",-20}\t{"Price",-10}");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var product in productList)
            {
                Console.WriteLine($"{product.ProductId,-10}\t{product.ProductName,-20}\t{product.Price,-10}");
            }
        }

        public void RemoveFromCart(int id)
        {
            foreach (var item in productList)
            {
                if (item.ProductId == id)
                {
                    productList.Remove(item);
                    break;
                }
            }
        }

        //Update Product
        public void UpdateProduct(Product product)
        {
            foreach (var item in productList)
            {
                if (item.ProductId == product.ProductId)
                {
                    item.ProductName = product.ProductName;
                    item.Price = product.Price;
                }
            }
        }
    }
}
