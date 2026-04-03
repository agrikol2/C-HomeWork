using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
namespace TourOfCsharp;

class Program
{
    static void Main()
    {
        Console.WriteLine(); 
        Console.WriteLine("Hi, user! Let's write a simple program.");
        Console.WriteLine("What's your Name: ");
        
        string? User_name = Console.ReadLine();
        string name;

        if (string.IsNullOrEmpty(User_name))
        {
            name = "User";
        }

        else
        {
            name = User_name;
        }

        Console.WriteLine("Hello, " + name + "! This program is for learning C# syntax. Let's enter three numbers: ");
        
        double a,b;
        int n;

        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Error, please, enter the first number: ");
        }

        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Error, please, enter the second number: ");
        }
        
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Error, please, enter the third number: ");
        }



        Console.WriteLine($"Great! Now we can add them or subtract them: \n{a} + {b} = {a+b} \nand \n{a} - {b} = {a-b}");
        Console.WriteLine();
        Console.WriteLine("Now, let's solve the equation.");
        double result = first_task(a, b,0);
        int result_f = factorial(n);
        Console.WriteLine($"Factorial = {result_f}");
    }

    
    private static double first_task(double a, double b, double f)
    {

        double numerator = Math.Pow(a,2) + Math.Pow(b,Math.Pow(a,2));
        Console.WriteLine("numerator = " + numerator);


        double denominator;

        if (b==0)
        {
            Console.WriteLine("Warning: b = 0, division by zero in sin argument!");
            return double.NaN;
        }
        else
        {   
            denominator = b - Math.Pow(a,4) + Math.Sin((a/b)* Math.PI);
        }
        
        
        Console.WriteLine("denominator = " + denominator);

        f = numerator/denominator;
        Console.WriteLine("F = " + f);

        return f;
    }
    

    private static int factorial(int n)
    {
        if (n<0)
        {
            Console.WriteLine("a < 0, The factorial is defined only for non-negative numbers.");
            return -1;
        }   
        if(n == 0)
        {
            return 1;
        }
        return n * factorial(n-1);






    }

    
}   



