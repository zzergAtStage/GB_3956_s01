Console.Clear();
Console.WriteLine("Task #8: Read the user input and find all even numbers between 1 and entered value");
Console.Write("Input the number: ");
int rightValue = Convert.ToInt32(Console.ReadLine());
//declare an array and put there numbers
List<int> iArr = new List<int>();
//strarting from one
int iNum = 1, iCnt = 1;
while (iCnt < rightValue)
{
    iCnt++;
    if (iCnt % 2 == 0)
    {
        iArr.Add(iCnt);
        iNum++;
    }
}
Console.WriteLine("Even numbers are: " + string.Join(",",iArr));