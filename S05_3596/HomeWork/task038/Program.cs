
namespace HomeWork;

class task038
{
    static void Main(string[] args)
    {
        //Задача 38: Задайте массив вещественных чисел. 
        //Найдите разницу между максимальным и минимальным элементов массива.
        // [3 7 22 2 78] -> 76
        Console.Clear();
        double[] arr = HomeWork.Library.GetRandomRealArray(5, -2.00, 3.00);
        int minIndex = HomeWork.Library.GetIndexOfMinimalArrayMember(arr);
        int maxIndex = HomeWork.Library.GetIndexOfMaximalArrayMember(arr);
        HomeWork.Library.PrintArray(arr);
        Console.WriteLine($"Debug: minIndex={minIndex}; maxIndex={maxIndex}");
       
        double diff = arr[maxIndex] - arr[minIndex];
        Console.WriteLine($" -> {diff} ({arr[maxIndex]} - {arr[minIndex]} )");
    }
}
