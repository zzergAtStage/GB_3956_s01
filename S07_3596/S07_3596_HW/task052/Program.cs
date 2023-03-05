using Libraries;
namespace task052;
class Program
{
//     Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    static void Main(string[] args)
    {   
        static string GetArithmeticalOfCol(int[,] arr){
            string res = string.Empty;
            int rows = arr.GetLength(1);
            int cols = arr.GetLength(0); 
            double[] averageResults = new double[ rows];
            double avgTmp = 0;
            for (int i = 0; i < rows; i++)
            {
               for (int j = 0; j < cols; j++)
               {
                avgTmp += arr[j,i]; 
               }
               averageResults[i] = Math.Round(avgTmp / cols, 2);
               avgTmp = 0;
            }
            return String.Join("\t",averageResults);
        }
       
        Console.Clear();
        int sizeOfArray = 5;
        
        int leftRange = 0, rightRange = 20;
        int[,]  squareMatrix = 
            Library.GetRandomArray(sizeOfArray,sizeOfArray,leftRange,rightRange);
            // new int[,] {{1,4,7,2},
            // {5,9,2,3},
            // {8,4,2,4}
            // };
        Library.PrintArray(squareMatrix);
        
        System.Console.WriteLine("Average numbers of columns are:");
        System.Console.WriteLine(GetArithmeticalOfCol(squareMatrix));


    }
}
