// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();

do
{
    Console.Write("Enter some day of week: ");
    int dayOfWeek = Convert.ToInt32(Console.ReadLine());
    if (dayOfWeek > 7 || dayOfWeek < 1)
    {
        Console.Write("Enter correct day of week (1-7)");
    } else 
    {
    if (dayOfWeek == 6 || dayOfWeek == 7) {
        Console.WriteLine($"{dayOfWeek} -> Yes");
        return;
    } else
    {
        Console.WriteLine($"{dayOfWeek} -> No");
        return;
    }
    }
} while (true);
