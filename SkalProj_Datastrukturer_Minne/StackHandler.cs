using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class StackHandler
    {
       public static void ExamineStack()
    
        {
            while (true)
            {
                Console.WriteLine("\nStack Menu:");
                Console.WriteLine("1. Reverse a string");
                Console.WriteLine("0. Return to main menu");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter string to reverse: ");
                        string? input = Console.ReadLine();

                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("No input detected.");
                            break;
                        }

                        var stack = new Stack<char>();
                        foreach (char c in input)
                        {
                            stack.Push(c);
                            Console.WriteLine($"Pushed: {c}");
                        }

                        string reversed = "";
                        while (stack.Count > 0)
                        {
                            char popped = stack.Pop();
                            reversed += popped;
                            Console.WriteLine($"Popped: {popped}");
                        }

                        Console.WriteLine("Reversed string: " + reversed);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
