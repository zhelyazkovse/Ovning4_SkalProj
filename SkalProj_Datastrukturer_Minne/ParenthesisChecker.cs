using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class ParenthesisChecker
    {
       public static void CheckParenthesis()
        {
            while (true)
            {
                Console.WriteLine(Environment.NewLine + "Parenthesis Menu:");
                Console.WriteLine("1. Enter a string to check");
                Console.WriteLine("0. Return to main menu");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter string to check: ");
                        string input = Console.ReadLine();
                        var stack = new Stack<char>();
                        bool isCorrect = true;

                        foreach (char c in input)
                        {
                            if (c == '(' || c == '{' || c == '[')
                            {
                                stack.Push(c);
                            } else if (c == ')' || c == '}' || c == ']')
                            {
                                if (stack.Count == 0 ||
                                    (c == ')' && stack.Pop() != '(') ||
                                    (c == '}' && stack.Pop() != '{') ||
                                    (c == ']' && stack.Pop() != '['))
                                {
                                    isCorrect = false;
                                    break;
                                }
                            }
                        }

                        if (stack.Count != 0) isCorrect = false;

                        Console.WriteLine(isCorrect ? "Parentheses are correct!" : "Parentheses are incorrect!");
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
