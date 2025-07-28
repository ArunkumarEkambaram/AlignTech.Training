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
        //public AnotherClassBL(IProduct? product)
        //{
        //    _product = product;
        //}

        ////COnstructor Injection

        //public void GetProductByName(string name)
        //{
        //    //ProductDAL obj = new ProductDAL();
        //    var result = _product.GetProductbyName(name);
        //}

        //Method Injection
        //public void GetProduct(IProduct? product)
        //{
        //    _product = product;
        //    var result = _product.GetProduct();
        //    Console.WriteLine(result);
        //}

        public void GetProductByProperty()
        {
            var result = _product.GetProduct();
            Console.WriteLine(result);
        }
    }
}
