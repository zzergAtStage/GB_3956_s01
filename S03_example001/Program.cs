Console.Clear();
Console.WriteLine("Module getSector => input 1; getVector input => 2");
int choise = Convert.ToInt32(Console.ReadLine());
if (choise == 1)
{
   getSector(); 
} else if (choise == 2)
{
   double res = getVector();
   Console.WriteLine("Length of vector is = " + res);
}



static void getSector()
{
    Console.Write("Input x:");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input y:");
    int y = Convert.ToInt32(Console.ReadLine());

    if (x == 0 || y == 0)
    {
        Console.WriteLine("Wrong ınput!");
        return;
    }
    if (x > 0 && y > 0)
    {
        Console.WriteLine("The dot in first sector");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("The dot in fourth sector");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("The dot in second sector");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("The dot in third sector");
    }
    else
    {
        Console.WriteLine("Can not define the sector!");
    }
}


// Length of vector is AB = sqr((xB - xA)^2 + (yB - yA)^2)
static double getVector(){
    
    Console.Write("Input xA:");
    double xA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input yA:");
    double yA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input xB:");
    double xB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input yB:");
    double yB = Convert.ToInt32(Console.ReadLine());


    return (Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2))); 
}