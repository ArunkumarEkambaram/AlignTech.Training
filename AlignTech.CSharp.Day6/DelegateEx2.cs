namespace AlignTech.CSharp.Day6
{
    internal class DelegateEx2
    {

        //Action, Func and Predicate
        //Action - No Return Type and Takes 1 to 16 parameter
        //Func - Should have a return type and Takes 0 to 16 parameters
        //Predicate - Take 1 Parameter and returns bool

        public void Greet()
        {
            Console.WriteLine($"Welcome Guset");
        }

        public void Greet(string name)
        {
            Console.WriteLine($"Welcome, {name}");
        }

        public float Divide(int n1, int n2)
        {
            return (float)n1 / n2;
        }

        //Predicate
        public bool FindById(int id)
        {
            if (id == 1)
                return true;
            return false;
        }
    }
}
