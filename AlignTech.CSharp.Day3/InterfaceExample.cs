namespace AlignTech.CSharp.Day3
{
    public interface ITax
    {
        void PayTax();
        //void StateTax();

        //Optional Method
        void StateTax()
        {
            Console.WriteLine("State Tax is Optional");
        }
    }

    public interface IStateTax
    {
        //Optional Method
        void PayTax() { Console.Write("State Tax"); }
    }

    public interface ICentralTax
    {
        //Optional Method
        void PayTax() { Console.WriteLine("Central Tax"); }
    }
}
