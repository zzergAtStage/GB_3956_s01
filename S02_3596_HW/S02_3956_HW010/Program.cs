//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = Convert.ToInt32(Console.ReadLine());//Random.Shared.Next(10,1000);
int middleDigit = (number / 10) % 10;
Console.WriteLine($"{number} -> {middleDigit} ");
