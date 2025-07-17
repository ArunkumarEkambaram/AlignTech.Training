namespace AlignTech.CSharp.Day2
{
    internal class MethodParamter
    {
        //public void SumNumbers(int a, int b, int sum)
        //{
        //    sum = a + b;
        //    Console.WriteLine($"Output :{sum}");
        //}

        //Ref Example
        //public void SumNumbers(int a, int b, ref int sum)
        //{
        //    sum = a + b;
        //    Console.WriteLine($"Output :{sum}");
        //}

        ////Out Example
        public void SumNumbers(int a, int b, out int sum)
        {
           // sum++;
            sum = a + b;
            Console.WriteLine($"Output :{sum}");
        }
    }
}
