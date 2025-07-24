namespace AlignTech.CSharp.Day7.Models
{
    public class Product : IComparable<Product>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }

    public class UserProfile
    {
        public string UserId { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
    }
}
