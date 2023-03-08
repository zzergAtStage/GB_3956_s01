using Libraries;
namespace task054;
class Program
{//Задача 54: Задайте двумерный массив. Напишите программу, 
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
        SortIntegerArray(ref arrayToSortRows);
        Library.PrintArray(arrayToSortRows);
    }

    static  void SortIntegerArray(ref int[,] array){
        //sorting by rows
        for (int i = 0; i < array.GetLength(0); i++) //rows
        {
            int tmpArrayMember = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                 int minPosition = j;
                //get minimal member of row
                for (int x = j; x < array.GetLength(1); x++)
                {
                    if (array[i,x] < array[i,minPosition]) minPosition = x;
                }
                
                //System.Console.Write($"J->{j}[{i},{minPosition}] = {array[i,minPosition]}; ");
                if (array[i,j] > array[i,minPosition]){
                    tmpArrayMember = array[i,j];
                    array[i,j] = array[i,minPosition];
                    array[i,minPosition] = tmpArrayMember;
                }
            } 
            System.Console.WriteLine();           
        }
    }
}
