namespace AlignTech.LINQ.Day10.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //Referencing Category

        public int CategoryId { get; set; }

        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Mobile Phone", Price = 55000, CategoryId = 1 },
                new Product { Id = 1, Name = "Mobile Phone", Price = 55000, CategoryId = 1 },
                new Product { Id = 2, Name = "Jeans", Price = 600, CategoryId = 2},
                new Product { Id = 3, Name = "Laptop", Price = 55000, CategoryId = 1 },
                new Product { Id = 4, Name = "Shirt", Price = 990, CategoryId = 2 },
                new Product { Id = 5, Name = "Router", Price = 4599, CategoryId = 1 },
                new Product { Id = 6, Name = "Webcam", Price = 12999, CategoryId = 1 },
                new Product { Id = 7, Name = "Webcam", Price = 5999, CategoryId = 1 },
            };
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public IEnumerable<Category> GetCategories()
        {
            return new List<Category>
                {
                    new Category {Id=1, CategoryName="Electronics"},
                    new Category {Id=2, CategoryName="Clothing"},
                };
        }
    }
}
