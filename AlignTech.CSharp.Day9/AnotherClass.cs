namespace AlignTech.CSharp.Day9
{
    internal class AnotherClassBL
    {
        private IProduct _product;

        //Property Injection
        public IProduct ProductDataObject
        {
            set
            {
                _product = value;
            }
        }

        ////Constructor Injection
        //public AnotherClassBL(IProduct? product)
        //{
        //    _product = product;
        //}

        public void GetProductByName(string name)
        {
            //ProductDAL obj = new ProductDAL();
            var result = _product.GetProductbyName(name);
        }

        //Method Injection
        public void GetProduct(IProduct? product)
        {
            _product = product;
            var result = _product.GetProduct();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void GetProductByProperty()
        {
            var result = _product.GetProduct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
