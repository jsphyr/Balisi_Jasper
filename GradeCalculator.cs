using System;

class frmStudentGradeProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Name: ");
        string name = Convert.ToString(Console.ReadLine());

        Console.Clear();

        Console.Write("Math: ");
        double math = Convert.ToDouble(Console.ReadLine());

        Console.Write("English: ");
        double eng = Convert.ToDouble(Console.ReadLine());

        Console.Write("Science: ");
        double scie = Convert.ToDouble(Console.ReadLine());

        Console.Write("Filipino: ");
        double fil = Convert.ToDouble(Console.ReadLine());

        Console.Write("History: ");
        double his = Convert.ToDouble(Console.ReadLine());

        Console.Clear();

        double sum = math + eng + scie + fil + his;
        double ave = sum / 5;

        if (ave >= 75.00)
        {
            Console.WriteLine("The student passed!");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("The general average of student " + name + " is " + ave);
        }
        else
        {
            Console.WriteLine("The student failed.");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("The general average of student " + name + " is " + ave);
        }
    }
}

