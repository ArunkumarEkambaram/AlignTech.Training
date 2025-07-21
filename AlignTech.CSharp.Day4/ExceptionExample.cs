namespace AlignTech.CSharp.Day4
{
    public class ExceptionExample
    {
        public void TestMethod()
        {
            //Exception Example
            int[] arr = new int[2];

            //Handle All error
            try
            {
                try
                {
                    arr[3] = 100;
                    throw new NullReferenceException();
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("First Try Block :" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Top-Level : {ex.ToString()}");
            }
            //catch
            //{
            //    Console.WriteLine("Please try again later");
            //}
        }

        public void TestMethod2()
        {
            try
            {
                throw new ArgumentNullException("UserId", "UserId cannot be null");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ValidateUser()
        {
            throw new ArgumentNullException("UserId", "UserId cannot be null.");
        }

        public void ProcessUserData()
        {
            try
            {
                ValidateUser();
            }
            catch (ArgumentNullException ex)
            {
                throw new InvalidUserException("User Id cannot be blank", ex);
            }
        }
    }
}
