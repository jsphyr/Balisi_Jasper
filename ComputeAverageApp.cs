using System;

class ComputeAverageProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Grade Calculator!");
        Console.WriteLine("-------------------------------");

        //asks how many grades do you want to compute w/ valid integers
        int numGrades;
        while (true)
        {
            Console.Write("How many grades do you want to enter? ");
            if (int.TryParse(Console.ReadLine(), out numGrades) && numGrades > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        double[] grades = new double[numGrades];

        //loop for inputing grades w/ tryparse
        for (int i = 0; i < numGrades; i++)
        {
            while (true)
            {
                Console.Write($"Enter grade {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out grades[i]))
                {
                    if (grades[i] < 0 || grades[i] > 100)
                    {
                        Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid grade.");
                }
            }
        }

        //computation for averaging
        double sum = grades.Sum();
        double average = sum / numGrades;
        double roundedAverage = Math.Round(average); // rounded grades


        //shows output
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Average Grade: {average:F2}");
        Console.WriteLine($"Rounded-off Grade: {roundedAverage}");
        Console.WriteLine("-------------------------------");

        //shows grade equivalent 
        if (average >= 90)
        {
            Console.WriteLine("Congratulations! You got an A!");
        }
        else if (average >= 80)
        {
            Console.WriteLine("Good job! You got a B!");
        }
        else if (average >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else
        {
            Console.WriteLine("You need to study harder!");
        }
    }
}