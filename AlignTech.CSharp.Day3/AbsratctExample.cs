namespace AlignTech.CSharp.Day3
{

    //Method Overriding Example
    //Virtual or Abstract
    public abstract class Seller
    {
        public int SellerId;
        public string[] SellerLocation;

        public Seller(int sellerId, params string[] sellerLocation)
        {
            SellerId = sellerId;
            SellerLocation = sellerLocation;
        }

        // public abstract void PayTax();
        public virtual void DisplaySellerDetails()
        {
            Console.WriteLine($"Seller Id :{SellerId}");
            Console.WriteLine($"Location :{string.Join(",", SellerLocation)}");
        }
    }

    public class DomesticSeller : Seller, IStateTax, ICentralTax
    {
        public decimal DeliveryCharges;

        public DomesticSeller(int sellerId, params string[] sellerLocation) : base(sellerId, sellerLocation)
        {
            DeliveryCharges = 100;
        }
        public override void DisplaySellerDetails()
        {
            base.DisplaySellerDetails();
            Console.WriteLine($"Delivery Charges :{DeliveryCharges}");
        }

        //Explict Interface Implementation
        //void IStateTax.PayTax()
        //{
        //    Console.WriteLine("State Tax Paid");
        //}

        //void ICentralTax.PayTax()
        //{
        //    Console.WriteLine("Central Tax Paid");
        //}


        //Implementation of Abstract Method
        //public override void PayTax()
        //{
        //    Console.WriteLine("Tax Paid");
        //}

        //Implemeation of Interface Method
        //public void PayTax()
        //{
        //    Console.WriteLine("Domestic Tax Paid");
        //}   
    }

    public class InternationalSeller : Seller, ITax
    {
        public decimal ShippingCharges;
        public InternationalSeller(int sellerId, params string[] sellerLocation) : base(sellerId, sellerLocation)
        {
            ShippingCharges = 200;
        }
        public override void DisplaySellerDetails()
        {
            base.DisplaySellerDetails();
            Console.WriteLine($"Shipping Charges :{ShippingCharges}");
        }
        // public override void PayTax()
        //{
        //    Console.WriteLine("International Tax Paid");
        //}    

        //Implemeation of Interface Method
        public void PayTax()
        {
            Console.WriteLine("International Tax Paid");
        }
    }

    public class Retailer : ITax
    {
        public void PayTax()
        {
            Console.WriteLine("Retailer Tax Paid");
        }

        public void StateTax()
        {
            Console.WriteLine("State Tax Paid by Retailer");
        }
    }
}
