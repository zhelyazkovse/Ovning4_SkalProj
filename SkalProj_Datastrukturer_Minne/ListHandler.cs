using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class ListHandler
    {
       public static void ExamineList()
        {
            var list = new List<string>();

            while (true)
            {
                Console.WriteLine("\nList Menu:");
                Console.WriteLine("1. Add (+name)");
                Console.WriteLine("2. Remove (-name)");
                Console.WriteLine("0. Return to main menu");
                Console.Write("Enter your choice or command: ");
                string input = Console.ReadLine()!;

                if (input == "0")
                    return;

                if (input.StartsWith('+') || input.StartsWith('-'))
                {
                    if (input.Length < 2)
                    {
                        Console.WriteLine("Please use +name or -name.");
                        continue;
                    }

                    char nav = input[0];
                    string name = input.Substring(1);

                    switch (nav)
                    {
                        case '+':
                            list.Add(name);
                            Console.WriteLine($"Added {name}. Count: {list.Count}, Capacity: {list.Capacity}");
                            break;
                        case '-':
                            if (list.Remove(name))
                                Console.WriteLine($"Removed {name}. Count: {list.Count}, Capacity: {list.Capacity}");
                            else
                                Console.WriteLine($"{name} not found.");
                            break;
                    }
                } else
                {
                    Console.WriteLine("Invalid input. Use +name, -name, or 0 to return.");
                }

                Console.WriteLine("Current list: " + string.Join(", ", list));
            }
        }
    }
}
