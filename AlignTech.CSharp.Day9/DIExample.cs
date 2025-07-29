namespace AlignTech.CSharp.Day9
{
    //Abstraction Layer
    public interface IProduct
    {
        List<string> GetProduct();
        List<string> GetProductbyName(string name);
    }

    //Data Access Layer
    public class ProductDAL : IProduct
    {
        List<string> products = ["Pen", "WebCam", "Mobile Phone", "Laptop", "Water Bottle", "Pen"];
        public List<string> GetProduct()
        {          
            return products;
        }

        public List<string> GetProductbyName(string name)
        {
            List<string> newProduct= new List<string>();
            foreach (var item in products)
            {
                if (item.Contains(name))
                {
                    newProduct.Add(item);
                }
            }
            return newProduct;
        }
    }

    public class ProductDALV2 : IProduct
    {
        public List<string> GetProduct()
        {
            List<string> products = ["Mic", "Magnifier", "Monitor", "Router"];
            return products;
        }

        public List<string> GetProductbyName(string name)
        {
            throw new NotImplementedException();
        }
    }

    //Business Layer
    public class ProductBL
    {
        // private ProductDAL _productDAL = null;
        private IProduct _productDAL;

        //Constructor Injection
        public ProductBL(IProduct product)
        {
            _productDAL = product;
        }
        public void GetProduct()
        {
            var products = _productDAL.GetProduct();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
