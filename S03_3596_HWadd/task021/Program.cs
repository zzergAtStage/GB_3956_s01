// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Формула нахождения длины отрезка в 3х мерном пространстве:
// AB = sqrt((xB - xA) ^ 2 + (yB - yA) ^ 2 + (zB + zA) ^ 2)
class Programm
{

    static void getVector()
    {

        Console.Write("Input xA:");
        double xA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input yA:");
        double yA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input zA:");
        double zA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input xB:");
        double xB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input yB:");
        double yB = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input zB:");
        double zB = Convert.ToInt32(Console.ReadLine());
        double res =  Math.Round(
                (Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2))),
                2
            )
            ;
        Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB}) -> {res}");
           
    }
    public static void Main(String[] args)
    {
        Console.Clear();
        getVector();
    }
}