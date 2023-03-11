using Libraries;
namespace task065;
class Program
{
    static string result = String.Empty;
    static void Main(string[] args)
    {
        Console.Clear();
        int M = Library.GetNumber("Input M value");
        int N = Library.GetNumber("Input N value");
        if (M < N) 
        {GetNaturalNumbersBetweenMN(M, N, M);
        } else {
            GetNaturalNumbersBetweenMN(N, M, N);
        }
        System.Console.WriteLine($"M = {M};N = {N} -> \"{result}\"");

    }
    static void GetNaturalNumbersBetweenMN(int M, int N, int step = 0)
    {
        
        if (step > N) return;
        result += step + ", ";
        if (M > N)
        { //revers
            step--;
        }
        else
        {
            step++;
        }
        GetNaturalNumbersBetweenMN(M, N, step);
    }

}
