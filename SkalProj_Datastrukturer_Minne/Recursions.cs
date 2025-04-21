using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class Recursions
    {
       public static void RecursiveOptions()
        {
            while (true)
            {
                Console.WriteLine(Environment.NewLine + "Recursion Menu");
                Console.WriteLine("1. Calculate the n-th recursive even number.");
                Console.WriteLine("2. Calculate the n-th recursive Fibonacci number.");
                Console.WriteLine("0. Return to main menu");
                Console.WriteLine("Your choice: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the n-th even number to calculate: ");
                        if (int.TryParse(Console.ReadLine(), out int nEven))
                        {
                            Console.WriteLine($"The {nEven}-th even number is: {RecursiveEven(nEven)}");
                        } else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter the n-th Fibonacci number to calculate: ");
                        if (int.TryParse(Console.ReadLine(), out int nFibonacci))
                        {
                            Console.WriteLine($"The {nFibonacci}-th Fibonacci number is: {RecursiveFibonacci(nFibonacci)}");
                        } else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static int RecursiveEven(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            return (RecursiveEven(n - 1) + 2);
        }

        static int RecursiveFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
    }
}
