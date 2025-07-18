namespace AlignTech.CSharp.Day3
{
    internal class ArrayExample
    {
        //Array Definition
        string[] cities;

        public ArrayExample(int size)
        {
            cities = new string[size];
        }

        public void GetCities()
        {
            for(int i=0;i<cities.Length; i++)
            {
                Console.Write("Enter a City Name :");
                cities[i] = Console.ReadLine();
            }
        }

        public void DisplayCities()
        {
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
