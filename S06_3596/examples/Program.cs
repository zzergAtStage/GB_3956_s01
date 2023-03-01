using Libraries;
namespace examples;
class Program
{
    static void Main(string[] args)
    {
        // int[] arr = Library.GetRandomArray(5,2,999);
        // Library.PrintArray(arr);
        // arr = Library.ReverseArray(arr);
        // Library.PrintArray(arr);
        // string boolS = Library.GetBinaryFromInt(255);
        // System.Console.WriteLine($"Result is: {boolS}");

        //         Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
        // Если N = 5 -> 0 1 1 2 3
        // Если N = 3 -> 0 1 1
        // Если N = 7 -> 0 1 1 2 3 5 8

        int Fibonacci = 8;
        int[] array = new int[Fibonacci];
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 || i == 1)
            {
                array[i] = i;
            }
            else
            {
                array[i] = array[i - 1] + array[i - 2];
            }
        }
        Library.PrintArray(array);
    }
}
