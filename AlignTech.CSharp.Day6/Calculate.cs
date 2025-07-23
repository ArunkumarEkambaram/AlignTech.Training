namespace AlignTech.CSharp.Day6
{
    internal class Calculate
    {
        public delegate int CalcEventHandler(int a, int b);

        public int AddNumber(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
