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
    }
}
