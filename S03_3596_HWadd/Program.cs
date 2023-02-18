// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив

class InvertArray
{
    static void InvertTheArray()
    {
        int[] arr = new int[] { 2, 5, 8, 0, 1, 7, 9 };
        int currItem, lastItem, size;
        size = arr.Length;
        Console.WriteLine("Array before inverting: " + String.Join(",", arr));
        for (int i = 0; i < size / 2; i++)
        {
            currItem = arr[i];
            lastItem = arr[size - 1 - i];
            arr[size - 1 - i] = currItem;
            arr[i] = lastItem;
        }
        Console.WriteLine("Array AFTER inverting: " + String.Join(",", arr));
    }

    public static void Main(String[] args)
    {
        InvertTheArray();
    }
}