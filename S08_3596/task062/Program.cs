using Libraries;
namespace task062;
class Program
{
    static int count = 0;
    static int arraySize = 4;
    static void Main(string[] args)
    {
        Console.Clear();
        int[,] spinArray = new int[arraySize, arraySize];
        //using a recursion to fill array with spin
        MazeFillingArray(String.Empty,0, 0, spinArray);
        Library.PrintArray(spinArray);
    }

    static void MazeFillingArray(string stageDebug, int row, int col, int[,] maze)
    {
        if ((row <= (maze.GetLength(0) - 1) && col <= (maze.GetLength(1) - 1))
            && row >= 0 && col >= 0
        && maze[row, col] == 0)
        {
            maze[row, col] = ++count;
            // Console.SetCursorPosition(row,col);
            // Console.Write($" {maze[row, col]} ");
            // Console.ReadKey();
            System.Console.WriteLine($"{stageDebug}=> count={count}; row={row}; col={col} ");
            MazeFillingArray("1",row, col + 1, maze);
            MazeFillingArray("2",row + 1, col, maze);
            MazeFillingArray("3",row, col - 1, maze);
            MazeFillingArray("4",row - 1, col, maze);


        }
    }
}
