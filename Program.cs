using System;


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
        Console.WriteLine("Now, let's solve the equation.\n");
        double result_first_task = first_task(a, b,0);
        int result_f = factorial(n);
        Console.WriteLine($"Factorial = {result_f}\n");
        Console.WriteLine("Now, second task (2)");




        double x,y;
        

        Console.Write("Enter x, but no more than 1 and no less than -1 = ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Error, please, enter the first number: ");
        }
        Console.Write("Enter y, but no more than 1 and no less than -1 = ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Error, please, enter the second number: ");
        }


        second_task(x,y);
        
        
        Console.WriteLine("\nThird task (3)\n");
    
    
        double e;
        Console.Write("Enter number E: ");
        
        while (!double.TryParse(Console.ReadLine(), out e))
        {
            Console.WriteLine("Error, please, enter number E: ");
        }

        third_task(e);

        
        
    }

    
    public static double first_task(double a, double b, double f)
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
    

    public static int factorial(int n)
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

    public static void second_task(double x, double y)
    {

        if (y > -x)
        {
            Console.WriteLine("Point x,y belongs to a part of the plane");
            
        }
        else
        {
            
            Console.WriteLine("Point x,y does not belong to a part of the plane");
        }
    
        
    }

    public static void third_task(double e)
    {
        double sum = 0;
        double n = 1;
        
        double y = 1 / Math.Pow((n+1),n);

        while (y >= e)
        {
            sum += y;
            n +=1;
            y = 1 / Math.Pow((n+1),n);
        }
        
        
        Console.WriteLine($"Сумма ряда с точностью E = {e} равна: {sum}");
        Console.WriteLine($"Количество учтённых членов: {n - 1}");
    }

}   



