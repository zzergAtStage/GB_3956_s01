//Write programm shows max digit in random generated numbers in [10-99] 
//1st get a nember bay Random
//convert number to array
//find max and print

int number = Random.Shared.Next(10,100);

Console.WriteLine("Number = " + number);
int lastDigit = number % 10;
Console.WriteLine("Mod = " + lastDigit);
int firstDigit = number / 10;
if (firstDigit > lastDigit)
{
    Console.WriteLine("max = " + firstDigit );
} else
{
    Console.WriteLine("max = " + lastDigit );
}
