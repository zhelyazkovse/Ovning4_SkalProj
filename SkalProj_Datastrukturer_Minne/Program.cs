using System;
using System.Reflection.Metadata.Ecma335;
namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        #region 1. Hur fungerar stacken och heapen?

        /*
         * Stacken (Last In - First Out, LIFO):
         * Stacken fungerar som en stapel av lådor.
         * Den sista som läggs på är den första som tas bort.
         * Används för metodanrop och lokala variabler (Value Types).
         * 
         * Kodexempel - Stacken:
         * 
         * void StackExample()
         * {
         *     int a = 5;
         *     int b = a;     // b får en kopia av a
         *     b = 10;        // ändrar INTE a
         * }
         * 
         * Heapen:
         * Ett område där objekt (Reference Types) lagras och nås via referenser.
         * Här sker Garbage Collection när minne inte längre används.
         * 
         * Kodexempel - Heapen:
         * 
         * class Person { public string Name; }
         * 
         * void HeapExample()
         * {
         *     Person p1 = new Person();
         *     p1.Name = "Anna";
         *     Person p2 = p1;
         *     p2.Name = "Lisa"; // Ändrar även p1.Name!
         * }
         */

        #endregion
      #region 2. Vad är Value Types respektive Reference Types och vad skiljer dem åt?

        /*
         * Value Types lagras direkt på stacken och inkluderar:
         * - Numeriska typer: byte, sbyte, short, ushort, int, uint, long, ulong
         * - Flyttal: float, double, decimal
         * - Övriga: char, bool, enum, struct
         * 
         * De kopieras vid tilldelning – varje variabel får sin egen kopia.
         * 
         * Reference Types lagras på heapen och inkluderar:
         * - class
         * - interface
         * - delegate
         * - array
         * - string
         * 
         * Variabler innehåller en referens till objektet – flera variabler kan peka på samma data.
         * 
         * Skillnaden:
         * - Value Types: oberoende kopior
         * - Reference Types: flera referenser till samma objekt
         */

        #endregion
        #region 3.  Följande metoder genererar olika svar, varför?

        /*
         * Exempel 1: Returnerar 3
         * 
         * int ReturnValue()
         * {
         *     int x = 3;
         *     int y = x;
         *     y = 4;
         *     return x;
         * }
         * 
         * x och y är Value Types. När y får värdet av x, skapas en kopia.
         * Ändringen av y påverkar inte x. Därför returneras 3. Detta är varför.
         * 
         * Exempel 2: Returnerar 4
         * 
         * class MyInt { public int MyValue; }
         * 
         * int ReturnValue2()
         * {
         *     MyInt x = new MyInt();
         *     x.MyValue = 3;
         *     MyInt y = x;
         *     y.MyValue = 4;
         *     return x.MyValue;
         * }
         * 
         * x och y är referenser till samma objekt i heapen.
         * När y.MyValue ändras, syns det också via x. Därför returneras 4. Detta är varför.
         */

        #endregion
      #region  4. Varför är det inte så smart att använda en stack i det här fallet?
        /*
         * En stack är inte lämplig för en ICA-kö eftersom den följer principen Först In Sist Ut(FILO).
         * Det skulle innebära att den som kommer först får vänta längst, vilket är orättvist och ologiskt i en vanlig kö.
         *
         * Exempel:
         * 
         * Stack: [A, B, C]
         * Dequeue: C
         * Queue: [A, B]
         *
         * I en kö ska den som kom först(A) få gå först och inte den som kom sist(C).
         */

        #endregion
        #region 5. Vilken metod är mest minnesvänlig och varför?

        /*
         * Iterativa funktioner är mer minnesvänliga än rekursiva.
         * Rekursion skapar ett nytt stackframe för varje anrop vilket kan leda till hög minnesförbrukning och stack overflow.
         * Iteration använder en loop och några få variabler vilket sparar minne.
         * Därför är iteration oftast att föredra ur ett minnesperspektiv.
         */

        #endregion

        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by entering the number \n(1, 2, 3 ,4, 5, 6, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. Recursive Options"
                    + "\n6. Iteration Options"
                    + "\n0. Exit the application");
                char input = ' '; 

                try
                {
                    input = Console.ReadLine()![0]; 
                }
                catch (IndexOutOfRangeException) 
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ListHandler.ExamineList();
                        break;
                    case '2':
                        QueueHandler.ExamineQueue();
                        break;
                    case '3':
                        StackHandler.ExamineStack();
                        break;
                    case '4':
                        ParenthesisChecker.CheckParenthesis();
                        break;
                    case '5':
                        Recursions.RecursiveOptions();
                        break;
                    case '6':
                        Iterations.IterationOptions();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter valid input (0, 1, 2, 3, 4, 5, 6)");
                        break;
                }
            }
        }
    }
}

