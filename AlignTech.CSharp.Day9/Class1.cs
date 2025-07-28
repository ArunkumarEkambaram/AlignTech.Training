namespace AlignTech.CSharp.Day9
{
    //Abstraction Layer
    public interface IProduct1
    {
        List<string> GetProduct();
    }

    //Data Access Layer
    public class ProductDAL1 : IProduct1
    {
        public List<string> GetProduct()
        {
            List<string> products = ["Pen", "WebCam", "Mobile Phone", "Laptop", "Water Bottle"];
            return products;
        }
    }

    public class ProductDAL2 : IProduct1
    {
        public List<string> GetProduct()
        {
            List<string> products = ["Mic", "Magnifier", "Monitor", "Router"];
            return products;
        }
    }

    //Business Layer
    public class ProductBL1
    {
         //private ProductDAL_V2 _productDAL = null;
        private IProduct1 _productDAL;

        //public ProductBL1()
        //{
        //    _productDAL= new ProductDAL2();
        //}

        public ProductBL1(IProduct1 product1)
        {
            _productDAL = product1;
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
