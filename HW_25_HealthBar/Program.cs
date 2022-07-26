using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_25_HealthBar
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            while (true)
            {
                DrawBar(ConsoleColor.Blue, 2, 100);
            }
        }

        static void DrawBar(ConsoleColor color, int value, int maxValue)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;

            Console.WriteLine("Кол - во жизней");  
            Console.Write("[");

            Console.ForegroundColor = color;
            for (int i = 0; i < value; i++)
            {
                Console.Write('#');
            }

            Console.ForegroundColor = defaultColor;
            for (int i = 0; i < maxValue - value; i++)
            {
                Console.Write('_');
            }
            Console.Write(']');

            Console.ReadKey();
        }
    }
}
