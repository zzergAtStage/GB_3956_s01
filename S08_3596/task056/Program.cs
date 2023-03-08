using Libraries;
namespace task056;
class Program
{ //Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    static int minSumRowNumber = 0;
    static void Main(string[] args)
    {
        
        Console.Clear();
        int arrSize = Library.GetNumber("Input array side size");
        int[,] squareArray = Library.GetRandomArray( length: arrSize, height: arrSize);
        Library.PrintArray(squareArray);
        
        int minSumOfArrayRowMembers = GetMinSumOfRowMembers(ref squareArray);
        System.Console.WriteLine($" The row #{minSumRowNumber} have minimal summary value = {minSumOfArrayRowMembers}");
    }

    static int GetMinSumOfRowMembers(ref int[,] pArray){
        int minSumOfRow = 0;
        
        for (int i = 0; i < pArray.GetLength(0); i++)
        {   
            int tmpSumOfRow = 0;
            for (int j = 0; j < pArray.GetLength(1); j++)
            {
                tmpSumOfRow += pArray[i,j];
            }
            if (i == 0) minSumOfRow = tmpSumOfRow;
            if ((minSumOfRow > tmpSumOfRow) && i != 0) {
                minSumOfRow = tmpSumOfRow;
                minSumRowNumber = i + 1;
            }
            
        }
        return minSumOfRow;
    }
}
