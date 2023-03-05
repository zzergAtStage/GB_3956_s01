using Libraries;
namespace task050;
class Program
{
    static void Main(string[] args)
    {
        // Задача 50. Напишите программу, которая на вход принимает позиции элемента
        // в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3​
        // 8 4 2 4
        // // 1 7 -> такого числа в массиве нет
        Console.Clear();
        int arraySize = Library.GetNumber("Input size for new square matrix (array) ");
        int leftRange = 1, rightRange = 999;
        int[,] squareMatrix = Library.GetRandomArray(arraySize, arraySize, leftRange, rightRange);
        Library.PrintArray(squareMatrix);
        System.Console.WriteLine("* Remember: index begins from 0!");
        int rowPositionOfElement = Library.GetNumber("Input row= ");
        int colPositionOfElement = Library.GetNumber("Input column=");
        if ((squareMatrix.GetLength(0) - 1) < rowPositionOfElement || (squareMatrix.GetLength(1) - 1) < colPositionOfElement)
        {
            System.Console.WriteLine($"There is no element with index [{rowPositionOfElement},{colPositionOfElement}] in Matrix");
        }
        else
        {
            System.Console.WriteLine($" your element[{rowPositionOfElement},{colPositionOfElement}]: "
                + $"{squareMatrix[rowPositionOfElement, colPositionOfElement]}");
        }
    }
}
