internal class Program
{
    public static void Main(string[] args){
        Console.Clear();
        int numberEven = 0;
        Console.WriteLine("Task #6 : Check the number - is it even?");
        Console.Write("Input natural number: ");
        numberEven = Convert.ToInt32(Console.ReadLine());
        string answer = " doesn't belong to even numbers ";
        if  (numberEven % 2 == 0) {
            answer = " really is even ";
        }
        Console.WriteLine("Number " + numberEven + answer);
    }
}
