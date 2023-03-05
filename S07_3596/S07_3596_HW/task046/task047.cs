using Libraries;
namespace task047;
class task047
{
    static void Main(string[] args)
    {
// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
        Console.Clear();
        int m = 3, n = 4;
        double leftRange = -10, rightRange = 10;
        Library.PrintArray(Library.GetRandomRealArray(m, n, leftRange, rightRange));
    }
}
