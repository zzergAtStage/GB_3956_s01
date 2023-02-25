// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*A palindrome is a word, number, phrase, or other sequence of symbols that reads the same backwards as forwards,
 such as the words madam or racecar, the date and time 12/21/33 12:21, and the sentence: "A man, a plan, a canal  Panama"*/
//Алгоритм 1: Развернуть число с использованием метода invertArray,
// предварительно разобрав на целочисленный массив методом деления десятичным остатком - дорого и больше кода!
//Алгорим 2: Не используя массив сравнивать LastNum == CurrNum двигаясь навстречу с двух сторон числа. 
//*учесть что всегда 5-ти значное числов
class S03_3596_HW19
{
    public static bool ifDebug = false;
    static bool checkPolindrom(int param1)
    {
        int param2, tmpValue, doadd;
        //Разбираем число на косточки, разворачиваем и сравниваем
        doadd = 10000;
        tmpValue = param1;
        param2 = 0;
        while (tmpValue > 0)
        {
            param2 += (tmpValue % 10) * doadd;
            tmpValue /= 10;
            doadd /= 10;
            if (ifDebug) { Console.WriteLine($"Debug: tmpValue={tmpValue}; param2={param2}; doadd={doadd}; "); }
        }
        return (param1 == param2);
    }

    public static void Main(string[] args)
    {
        Console.Clear();
        S03_3596_HW19.ifDebug = false;
        Console.Write("Input checked for polindromic value: ");
        int param = Convert.ToInt32(Console.ReadLine());
        if ((param % 10000) != 0)
            if (checkPolindrom(param))
            {
                Console.Write($"{param} => true");
            }
            else
            {
                Console.Write($"{param} => false");
            }
    }
}