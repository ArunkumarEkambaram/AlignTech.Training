using AlignTech.CSharp.Day7.Models;

namespace AlignTech.CSharp.Day7
{
    public class NameComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.ProductName.CompareTo(y.ProductName);
        }
    }

    public class PriceComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
