
namespace AlignTech.CSharp.Day4
{
    public class Customer
    {
        private string _firstName;
        private decimal _price;

        //Full Property
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price should be greater than zero");
                }
                _price = value;
            }
        }

        //Auto_implemented Property
        public int Age { get; set; }

        //Readonly Property
        public int Salary { get; } = 50000;

        //Init Property
        public int Shipping { get; init; }

        public Customer()
        {
            //Initialze Init Property
            Shipping = 500;
        }
    }
}
