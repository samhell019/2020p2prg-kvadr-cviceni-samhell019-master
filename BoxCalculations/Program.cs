using System;

namespace BoxCalculations
{
    class Program
    {
        /// <summary>
        /// Repeats message until valid floating point number above zero is entered
        /// </summary>
        /// <param name="message">message to be displayed, ": " is added at the end</param>
        /// <returns>float</returns>
        static float ReadNumber(string message)
        {
            float result = 0;
            string floatText;
            do
            {
                Console.Write(message + ": ");
                floatText = Console.ReadLine();
            }
            while (!float.TryParse(floatText, out result) || result <= 0);
            return result;
        }

        // NOTE: Commented out text is removed this way for program to be executable
        static void Main(string[] args)
        {
            Console.WriteLine("Výpočet vlastností kvádru");
            Console.WriteLine("Zadejte počáteční hodnoty");
            float a = ReadNumber("A");
            float b = ReadNumber("B");
            float c = ReadNumber("C");
            bool endIt = false;
            Box box = new Box(a, b, c);
            do
            {
                Console.WriteLine("Povrch: " + box.GetSurface());
                Console.WriteLine("Objem: " + box.GetVolume());
                Console.WriteLine("---------------------");
                ConsoleKey key;
                Console.WriteLine("Možnosti: nastav [A], nastav [B], nastav [C], [S]konči");
                do
                {          
                    key = Console.ReadKey().Key;                    
                }
                while (key != ConsoleKey.A && key != ConsoleKey.B && key != ConsoleKey.C && key != ConsoleKey.S);
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.A: /*box.SetA(ReadNumber("A"));*/ break;
                    case ConsoleKey.B: /*box.SetB(ReadNumber("B"));*/ break;
                    case ConsoleKey.C: /*box.SetC(ReadNumber("C"));*/ break;
                    case ConsoleKey.S: endIt = true; break;
                }
            }
            while (endIt == false);
        }
    }
}
