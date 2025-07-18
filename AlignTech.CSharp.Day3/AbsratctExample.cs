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

        public abstract void PayTax();
        public virtual void DisplaySellerDetails()
        {
            Console.WriteLine($"Seller Id :{SellerId}");
            Console.WriteLine($"Location :{string.Join(",", SellerLocation)}");
        }
    }

    public class DomesticSeller : Seller
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

        public override void PayTax()
        {
            Console.WriteLine("Tax Paid");
        }
    }

    public class InternationalSeller : Seller
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
         public override void PayTax()
        {
            Console.WriteLine("International Tax Paid");
        }
    }
}
