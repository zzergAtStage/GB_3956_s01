using Libraries;
namespace task058;
class Program
{ //Задача 54: Задайте двумерный массив. Напишите программу, 
  //которая упорядочит по возрастанию элементы каждой строки двумерного массива.

    static void Main(string[] args)
    {
        Console.Clear();
        int leftRange = 1;
        int rightRange = 10;
        int countRows = Library.GetNumber("Input rows count = ");
        int countColumns = Library.GetNumber("Input columns count = ");
        int[,] arrayToSortRows = Library.GetRandomArray(countRows, countColumns,leftRange,rightRange);

        Library.PrintArray(arrayToSortRows);
        SortIntegerArray(arrayToSortRows);
        Library.PrintArray(arrayToSortRows);
    }

    static void SortIntegerArray(int[,] array){
        //sorting by rows
        for (int i = 0; i < array.GetLength(0); i++) //rows
        {
            int maxArrayMember = array[i,0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (maxArrayMember > array[i,j]){
                    array[i,j-1] = array[i,j];
                    array[i,j] = maxArrayMember;
                }
            }            
        }

    }
}
