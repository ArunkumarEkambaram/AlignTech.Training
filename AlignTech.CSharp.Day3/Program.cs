//Array Example
//Single Dimensional Array Example
using AlignTech.CSharp.Day3;
using System.Transactions;

int[] arr = new int[5];

int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };

int[] arr2 = { 1, 2, 3, 4, 5, 5 };

//For Loop Example
//for (int i = 0; i < arr1.Length; i++)
//{
//    Console.WriteLine($"Array :{i}:Value :{arr1[i]}");
//}



//Get Array from User Input
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine($"Enter Value for Index {i}:");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//foreach (int x in arr)
//{
//    Console.WriteLine(x);
//}


//Two Dimensional Array Example
//Syntax: <datatype>[,] arryName= new <datatype>[rows, columns]; 

int[,] studentMarks = new int[3, 4]
{
    { 1001, 55, 66, 77},
    { 1002, 55, 66, 77},
    { 1003, 55, 66, 77},
};

//for (int i = 0; i < studentMarks.GetLength(0); i++)
//{
//    for (int j = 0; j < studentMarks.GetLength(1); j++)
//    {
//        Console.Write($"{studentMarks[i, j]} ");
//    }
//    Console.WriteLine();
//}

//Jagged Array Example
//Syntax: <datatype>[][] arrayName = new <datatype>[rows][];

//int[][] jArray = new int[3][];
//jArray[0] = new int[2] { 1, 2 };
//jArray[1] = new int[3] { 3, 4, 5 };
//jArray[2] = new int[4] { 6, 7, 8, 9 };

//for (int i = 0; i < jArray.Length; i++)
//{
//    for (int j = 0; j < jArray[i].Length; j++)
//    {
//        Console.Write($"{jArray[i][j]} ");
//    }
//    Console.WriteLine();
//}

//Dynamic Array Size
Console.WriteLine($"Enter the Number of Cities: ");
int size = Convert.ToInt32(Console.ReadLine());
ArrayExample obj = new ArrayExample(size);
//Get Cities
obj.GetCities();
//Display Cities
obj.DisplayCities();