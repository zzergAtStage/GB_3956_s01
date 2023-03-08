namespace Libraries;

public class Library
{
    const int defaultLeftRange = 1;
    const int defaultRightRange = 10;
    public static double[] GetRandomRealArray(int length, double leftRange, double rigthRange)
    {
        /*
        become a length of one=dimentions array of double with the range of generating elements
        */
        double[] arr = new double[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Math.Round((Random.Shared.NextDouble() * (rigthRange - leftRange) + leftRange), 2);
        }

        return arr;
    }
    public static double[,] GetRandomRealArray(int length, int height, double leftRange, double rightRange)
    {
        /*
        become a length of matrix array of double with the range of generating elements

        */
        double[,] arr = new double[length, height];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < height; j++)
            {
                arr[i, j] = Math.Round((Random.Shared.NextDouble() * (rightRange - leftRange) + leftRange), 2);
            }
        }

        return arr;
    }
    public static int[] GetRandomArray(int length
                            , int leftRange = defaultLeftRange
                            , int rightRange = defaultRightRange)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Random.Shared.Next(leftRange, rightRange);
        }

        return arr;
    }

    public static int[,] GetRandomArray(int length, int height
                                    , int leftRange = defaultLeftRange
                                    , int rightRange = defaultRightRange)
    {
        int[,] arr = new int[length, height];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = Random.Shared.Next(leftRange, rightRange);
            }
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
    public static void PrintArray(double[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }
    public static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }
    /// <summary>
    /// Print array with different types of data
    /// </summary>
    /// <param name="arr">Incoming array of objects (two dimensions) </param>
    /// <typeparam name="T">Type of data</typeparam>
    public static void PrintArray<T>(T[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Type elementType = arr[i, j].GetType();

                if (elementType == typeof(int))
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
                else if (elementType == typeof(string))
                {
                    Console.Write("{0,-20}", arr[i, j]);
                }
                else if (elementType == typeof(double))
                {
                    Console.Write("{0,8:F2}", arr[i, j]);
                }
            }
            Console.WriteLine();
        }
         Console.WriteLine();
    }

    public static int GetIndexOfMinimalArrayMember(double[] array)
    {
        double min = array[0];
        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
                // Console.WriteLine($" minIndex = {minIndex}; i={i}; min={min}");
            }
        }
        return minIndex;
    }
    public static int GetIndexOfMaximalArrayMember(double[] array)
    {
        double max = array[0];
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
                // Console.WriteLine($" maxIndex = {maxIndex}; i={i}; max={max}");
            }
        }
        return maxIndex;
    }
    //reverse array
    public static int[] ReverseArray(int[] array)
    {
        int tmp = 0;

        for (int i = 0; i < array.Length / 2; i++)
        {
            tmp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = tmp;

        }
        return array;

    }
    public static string GetBinaryFromInt(int value, string arrS = "")
    {
        //Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
        // 45 -> 101101
        // 3  -> 11
        // 2  -> 10
        //TODO 
        if (value < 2) return arrS + " " + value;
        int rest = value % 2;// = 0- > (int.length -1)
        int temp = value / 2;
        arrS = arrS + " " + rest.ToString();
        System.Console.WriteLine(arrS);
        arrS = GetBinaryFromInt(temp, arrS);
        return arrS;
    }
    //ınput of integer array with fix dimention
    public static int[] GetArrayWithFixSize(int size, string prompt = "")
    {
        int[] inputArray = new int[size];
        Console.WriteLine($"{prompt}:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"  Input number #{i + 1}: ");
            inputArray[i] = int.Parse(Console.ReadLine());
        }
        return inputArray;
    }

    //input one integer with prompt
    public static int GetNumber(string prompt = "")
    {
        System.Console.Write($"{prompt}: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    public static string GetNumberS(string prompt = "")
    {
        System.Console.Write($"{prompt}: ");
        string numberS = Console.ReadLine();
        return numberS;
    }
    public static double GetNumberD(string prompt = "")
    {
        System.Console.WriteLine($"{prompt}: ");
        double numberD = double.Parse(Console.ReadLine());
        return numberD;
    }
}
