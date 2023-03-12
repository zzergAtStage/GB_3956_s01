using Libraries;
namespace task069;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int A = Library.GetNumber("Input number A");
        int B = Library.GetNumber("Input number B");
        Console.WriteLine($"The result of raising A({A}) to the power of B({B}) is: {GetPowWithRecursion(A,B)}");

    }

    static int GetPowWithRecursion(int A, int B){
        
        if (B == 0) return 1;
        else return A * GetPowWithRecursion(A, B - 1);
    }
}
