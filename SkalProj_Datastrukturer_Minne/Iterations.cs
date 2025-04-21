using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class Iterations
    {
        public static void IterationOptions()
        {

            while (true)
            {
                Console.WriteLine(Environment.NewLine, "Iteration Menu");
                Console.WriteLine("1. Iteratively calculate the n-th even number");
                Console.WriteLine("2. Iteratively calculate the n-th Fibonacci number");

                Console.WriteLine("0. Return to main menu");
                Console.WriteLine("Your choice: ");
                string? choice = Console.ReadLine();
                if (choice == null)
                {
                    Console.WriteLine("No input detected. Please try again.");
                    continue;
                }
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the n-th even number to calculate: ");
                        if (int.TryParse(Console.ReadLine(), out int nEven))
                        {
                            Console.WriteLine($"The {nEven}-th even number is: {IterativeEven(nEven)}");
                        } else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter the n-th Fibonacci number to calculate: ");
                        if (int.TryParse(Console.ReadLine(), out int nFibonacci))
                        {
                            Console.WriteLine($"The {nFibonacci}-th Fibonacci number is: {IterativeFibonacci(nFibonacci)}");
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

        static int IterativeFibonacci(int n)
        {
            if (n <= 1)
                return n;
            int a = 0;
            int b = 1;
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
            }
            return result;



        }
        static int IterativeEven(int n)
        {
            int result = 2;
            for (int i = 1; i < n; i++)
            {
                result += 2;
            }
            return result;
        }
    }
}
