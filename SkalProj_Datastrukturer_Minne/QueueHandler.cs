using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class QueueHandler
    {
        public static void ExamineQueue()
        {
            var queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\nQueue Menu:");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("0. Return to main menu");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter value to enqueue: ");
                        string value = Console.ReadLine()!;
                        queue.Enqueue(value);
                        break;

                    case "2":
                        if (queue.Count > 0)
                        {
                            Console.WriteLine("Dequeued: " + queue.Dequeue());
                        } else
                        {
                            Console.WriteLine("Queue is empty.");
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("Queue: " + string.Join(", ", queue));
            }
        }
    }
}
