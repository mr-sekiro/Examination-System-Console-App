using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class ConsoleUI
    {
        public static int ReadInt(string message, int min, int max)
        {
            int value;
            do
            {
                Console.Write($"{message}: ");
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                    return value;
                Console.WriteLine("Invalid input, try again.");
            } while (true);
        }

        public static string ReadText(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine() ?? "";
        }
    }
}
