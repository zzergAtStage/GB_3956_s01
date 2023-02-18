
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Inpit number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} ->");
for (int i = 1; i <= num; ++i)
{
   Console.Write($"{Math.Pow(i,3)},");
}