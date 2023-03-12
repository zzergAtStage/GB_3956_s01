using Libraries;
namespace task64;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int N = Library.GetNumber("Input number N");

        Console.WriteLine($"The result of natural numbers from N({N} to 1 is:)");
        System.Console.WriteLine($"N({N}) -> {GetNaturalNumInverted(N,",")}");

        string GetNaturalNumInverted(int N, string indent = ""){
            if (N == 1) return 1.ToString();
            else return (N) + indent + GetNaturalNumInverted(N-1,",");
        }
    }
}
