//Write programm shows max digit in random generated numbers in [10-999] 
//1st get a nember bay Random
//convert number to array
//find max and print

int number = Random.Shared.Next(10,1000);

Console.WriteLine("Number = " + number);
int lastDigit = number % 10;
//Console.WriteLine("Mod = " + lastDigit);
int firstDigit = number / 100;
int middleDigit = (number / 10) % 10;

Console.WriteLine($"numbers are: 1:{firstDigit} 2:{middleDigit} 3:{lastDigit}");
int res = firstDigit * 10 + lastDigit;
Console.WriteLine($"res = {res}");