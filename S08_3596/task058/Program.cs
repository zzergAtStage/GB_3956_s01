using Libraries;
namespace task058;
class Program
{ //Задача 58: Задайте две матрицы. Напишите программу, 
  //которая будет находить произведение двух матриц.

    static void Main(string[] args)
    {
        Console.Clear();
        int leftRange = 1;
        int rightRange = 10;
        int sideSize = Library.GetNumber("Input size of matrix = ");

        int[,] arrayFirst = Library.GetRandomArray(sideSize, sideSize, leftRange, rightRange);
        int[,] arraySecond = Library.GetRandomArray(sideSize, sideSize, leftRange, rightRange);
        Library.PrintArray(arrayFirst);
        Library.PrintArray(arraySecond);
        int[,] resultArray = Multiplay(ref arrayFirst, ref arraySecond);
        Library.PrintArray(resultArray);
    }

    static int[,] Multiplay(ref int[,] pArrayFirst, ref int[,] pArraySecond)
    {
        int sideSize = pArrayFirst.GetLength(0);
        int[,] resultArray = new int[sideSize, sideSize];

        for (int i = 0; i < sideSize; i++)
        {
            for (int j = 0; j < sideSize; j++)
            {
                resultArray[i, j] = pArrayFirst[i, j] * pArraySecond[i, j];
            }

        }
        return resultArray;
    }


}
