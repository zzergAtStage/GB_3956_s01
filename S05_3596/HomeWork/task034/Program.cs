namespace task034;
class Program
{
    static int[] GetRandomArray(int length, int leftRange, int rigthRange)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Random.Shared.Next(leftRange, rigthRange);
            }

            return arr;
        }
    static int CountEvenArrayMembers(int[] array){
        int count = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0) count += 1;
        }
        return count;
    }
    static void Main(string[] args)
    {
    //Задача 34: Задайте массив заполненный случайными положительными 
    // трёхзначными числами. Напишите программу, которая покажет количество 
    // чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2
    Console.Clear();
    int[] numbers = GetRandomArray(6,1,999);
    Console.WriteLine($"Generating array: [{String.Join(", ",numbers)}]");
    int count = CountEvenArrayMembers(numbers);
    Console.WriteLine($"Even numbers count: {count}");
    }
}
