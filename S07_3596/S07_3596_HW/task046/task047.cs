using Libraries;
namespace task047;
class task047
{
    static void Main(string[] args)
    {
        Console.Clear();
        int m = 3, n = 4;
        double leftRange = -10, rightRange = 10;
        Library.PrintArray(Library.GetRandomRealArray(m, n, leftRange, rightRange));
    }
}
