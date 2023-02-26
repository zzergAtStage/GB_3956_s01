namespace HomeWork;

public class Library
{
    
    public static double[] GetRandomRealArray(int length,double leftRange, double rigthRange)
    {
        double[] arr = new double[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Math.Round((Random.Shared.NextDouble() * (rigthRange - leftRange) + leftRange),2);
        }

        return arr;
    }
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
    public static void PrintArray(double[] array){
         Console.WriteLine($"[{String.Join(", ", array)}]");
    }
    
    public static int GetIndexOfMinimalArrayMember(double[] array){
        double min = array[0];
        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) {
                min = array[i];
                minIndex = i;
               // Console.WriteLine($" minIndex = {minIndex}; i={i}; min={min}");
            }
        }
        return minIndex;
    }
    public static int GetIndexOfMaximalArrayMember(double[] array){
        double max = array[0];
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) {
                max = array[i];
                maxIndex = i;
               // Console.WriteLine($" maxIndex = {maxIndex}; i={i}; max={max}");
            }
        }
        return maxIndex;
    }
   
}
