using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    internal class Print
    {
        public static void InCenter(string text)
        {
            int center = Console.LargestWindowWidth / 2 - 20;
            for (int i = 0; i < center; i++)
            {
                Console.Write(" ");
            }
            Console.Write(text);

        }

        public static void InCenterLine(string text)
        {
            int center = Console.LargestWindowWidth / 2 - 20;
            for (int i = 0; i < center; i++)
            {
                Console.Write(" ");
            }
            Console.Write(text);
            Console.WriteLine();
        }
    }
}
