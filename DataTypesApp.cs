using System;

class DataTypesProgram
{
    static void Main(string[] args)
    {
        //shows options and asks the user for an input
        Console.WriteLine("Welcome to the Fruit Market!");
        Console.WriteLine("===========================================");
        Console.WriteLine("We have the following fruits available:");
        Console.WriteLine("1. Apples");
        Console.WriteLine("2. Bananas");
        Console.WriteLine("3. Oranges");
        Console.Write("Which fruit would you like to buy? (1/2/3) : ");

        int fruitChoice = Convert.ToInt32(Console.ReadLine());
        string fruitName = "";
        double fruitPrice = 0;
        int fruitQuantity = 0;

        //depending on the input of the user, one of these 3 cases will be executed
        switch (fruitChoice)
        {
            case 1://case 1 is for option 1(apples)
                fruitName = "apples";
                Console.Write("How many apples do you want to buy? ");
                fruitQuantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("What's the total price of 6 apples? $");
                fruitPrice = Convert.ToDouble(Console.ReadLine());
                break;
            case 2://case 2 is for option 2(bananas)
                fruitName = "bananas";
                Console.Write("How many bananas do you want to buy? ");
                fruitQuantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("What's the total price of 4 bananas? $");
                fruitPrice = Convert.ToDouble(Console.ReadLine());
                break;
            case 3://case 3 is for option 3(oranges)
                fruitName = "oranges";
                Console.Write("How many oranges do you want to buy? ");
                fruitQuantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("What's the total price of 6 oranges? $");
                fruitPrice = Convert.ToDouble(Console.ReadLine());
                break;
            default://condition to continue looping until a condition is met
                Console.WriteLine("Invalid choice. Please try again!");
                return;
        }

        //logic for price per product and for the total amount
        double fruitPricePerUnit = fruitPrice / (fruitChoice == 1 || fruitChoice == 3 ? 6 : 4);
        double fruitTotalCost = fruitPricePerUnit * fruitQuantity;

        //displays the final output/receipt
        Console.WriteLine("===========================================");
        Console.WriteLine($"You're buying {fruitQuantity} {fruitName}!");
        Console.WriteLine($"The price per {fruitName} is ${fruitPricePerUnit:F2}");
        Console.WriteLine($"Your total cost for {fruitName} is ${fruitTotalCost:F2}");
        Console.WriteLine("===========================================");
        Console.WriteLine("Thanks for shopping at the Fruit Market!");
    }
}