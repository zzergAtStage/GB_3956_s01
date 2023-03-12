using Libraries;
namespace task067;
class Program
{
    //static int sum = 0;
    static void Main(string[] args)
    {
        Console.Clear();
        int number = Library.GetNumber("Make your choice, podavan");
        int tmpValue = number;
        
         System.Console.WriteLine($"Summ digits of {number} -> {GetSummOfDigits(tmpValue)}");
    }
    static int GetSummOfDigits(int tmpValue){
        if (tmpValue < 10) return tmpValue;
        int sum = tmpValue % 10 + GetSummOfDigits(tmpValue / 10);
        return sum;
       
    }
}
