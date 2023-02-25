internal class Program {
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Task 004: Finding a maximum value of three numbers :");

        int[] inArr = new int[3] { 2, 3, 7 };
        ShowArr(inArr);
        inArr = new int[3] { 44, 5, 78 };
        ShowArr(inArr);
        inArr = new int[3] { 22, 3, 9 };
        ShowArr(inArr);
        
        static void ShowArr(int[] inArr)
        {
            Console.WriteLine("Numbers: " + string.Join(",",inArr));
            Console.WriteLine("Max number is: " + Program.GetMaxNumber(inArr));
        }
    }

    public static int GetMaxNumber(int[] arr){
        int max = arr[0];
        int iCnt = 1; //save on iteration cycle
        while (iCnt < arr.Length){
            if (arr[iCnt] > max) {
                max = arr[iCnt];
            }
            iCnt++;
        }
        return max;
    }
}
