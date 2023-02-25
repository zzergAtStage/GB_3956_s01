internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int countI = 0;
        while (countI < 3)
        {
           
            Console.Clear();
            Console.WriteLine("Iteration " + (countI + 1));
            Console.WriteLine("   Input first value(a):");
            Console.SetCursorPosition(4, 2);
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   Input second value(b):");
            var currPos = Console.GetCursorPosition(); //ValueTuple
            Console.SetCursorPosition(4, currPos.Top );
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(1, currPos.Top );
            //cheking a value
             int max = secondNumber;
            if (firstNumber > secondNumber)
            {
                max = firstNumber;
            } 
            Console.SetCursorPosition(currPos.Top + 10, currPos.Top + 1);
            Console.WriteLine("Max value is: " + max);
            Console.WriteLine("Press any key...");
            Console.ReadKey(true);
            countI++;
        }
    }
}


