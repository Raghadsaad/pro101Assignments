// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Choose an operation (+, -, *, /): ");
        string operation = Console.ReadLine();

       
        if (operation == "+")
        {
            Console.WriteLine("Result: " + (num1 + num2));
        }
        else if (operation == "-")
        {
            Console.WriteLine("Result: " + (num1 - num2));
        }
        else if (operation == "*")
        {
            Console.WriteLine("Result: " + (num1 * num2));
        }
        else if (operation == "/")
        {
            if (num2 != 0)
            {
                Console.WriteLine("Result: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operation.");
        }
    }
}
