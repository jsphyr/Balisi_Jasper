using System.Diagnostics;

class appleMarket
{
    static void Main (string[] args)
    {
        double apple = 32.50;

        Console.Write("Enter the number of apples you want to purchase: ");
        double buyApple = Convert.ToDouble(Console.ReadLine());
        double valueApple = apple * buyApple;

        Console.Clear(); 
        Console.Write("The total price of " + buyApple + " is " + valueApple);
        Console.WriteLine("\n------------------------------------------");
        Console.Write("The value of the converted price is: " + Math.Floor(valueApple));
    }
}



