namespace task063;
class Program
{
    static string result = String.Empty;
    static void Main(string[] args)
    {
        int currentIteration = 1;
        Console.Clear();
        int N = Libraries.Library.GetNumber("Input N");
        GetNaturalNumbers(N, currentIteration);
        System.Console.WriteLine($"N = {N} -> \"{result}\"");
    }
    static void GetNaturalNumbers(int N, int currentIteration)
    {
        if (currentIteration > N)
        {
            return;
        }
        else
        {
            if (currentIteration == N) { //bantiki
                result += currentIteration; 
            } else { 
                result += currentIteration + ", "; 
                }
            currentIteration++;
            GetNaturalNumbers(N, currentIteration: currentIteration); //recursion
        }

    }
}
