using AlignTech.CSharp.Day7.Models;
using System.Collections;

namespace AlignTech.CSharp.Day7
{
    public interface IProduct
    {
        void Add(Product product);
    }
    public class MyCollection<T> : IEnumerable<T> where T : class, new()
    {
        List<T> myProducts = new List<T>();

        public void Add(T product)
        {
            myProducts.Add(product);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in myProducts)
            {
                yield return item;
            }
        }

        public void Remove(T product)
        {
            myProducts.Remove(product);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myProducts.GetEnumerator();
        }
    }
}
