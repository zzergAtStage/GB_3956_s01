// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int getDigit(int value, int inrow)
{
    int p = (int)Math.Pow(10,inrow) ;
    value = value / p;
    return (value % 10);
}

Console.Clear();
Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = 2;

if (number < 100) //если число низкоразрядное вернем сразу
{
    Console.WriteLine($"{number} -> третьей цифры нет");
    return;
} 
if (number > 99 && number < 1000) //если до 1000 вернем по модулю
{
    Console.WriteLine($"{number} -> {number % 10}");
    return;
}int tst = number; //иначе найдем сколько разрядов в числе  и вернем уже от числа ЛЮБОЙ разрядности третье
for (int i = 0; tst > 1000; i++)
{
    tst /= 10;
    thirdDigit = i;
}

int res = getDigit(number, thirdDigit + 1);

Console.WriteLine($"{number} -> {res}");
