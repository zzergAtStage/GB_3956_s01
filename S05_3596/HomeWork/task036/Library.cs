// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.
namespace HomeWork;

public class Library
{
    public static int[] GetRandomArray(int length, int leftRange, int rigthRange)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Random.Shared.Next(leftRange, rigthRange);
        }

        return arr;
    }
    public static (int, int) SumPositiveAndNegotiveElements(int[] arr)
    {
        int sumPositive = 0; //summ of positive elements of array
        int sumNegative = 0; //summ of negative elements of array

        foreach (int num in arr)
        {
            if (num > 0)
            {
                sumPositive += num;
            }
            else
            {
                sumNegative += num;
            }
        }
        return (sumNegative, sumPositive);
    }
    public static void PrintArray(int[] array){
         Console.WriteLine($"[{String.Join(",", array)}]");
    }
    
   
}
