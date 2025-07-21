namespace AlignTech.CSharp.Day4
{
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }
            return str.Split(new[] { ' ', '\t', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void GetAllException(this ExceptionExample obj, string str)
        {
            Console.WriteLine("Getting all the exceptions" + str);
        }

        public static void PrintMethod<T>(this T obj)
        {
            Console.WriteLine("Print Method");
        }        
    }

    public interface IUserDetails
    {
        void Add();
    }

    public class UserDetails : IUserDetails
    {
        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
