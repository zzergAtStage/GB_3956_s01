namespace HomeWork;
using  HomeWork;
class task36
{
    
   public static void Main(string[] args)
    {
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
        Console.Clear();
        int[] numbers = HomeWork.Library.GetRandomArray(7,-99,99); 
        HomeWork.Library.PrintArray(numbers);
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i%2 != 0){
                sum += numbers[i];
            }
        }
        Console.WriteLine($" -> {sum}");
    }
}
