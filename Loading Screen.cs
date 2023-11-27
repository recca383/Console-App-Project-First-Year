using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    class LoadingScreenAnimation
    {

        public static void AnimateNumbers(string[] numbers, int repeatcount = 5, int delay = 100)
        {
            for (int i = 0; i < repeatcount; i++)
            {
                foreach (string number in numbers)
                {
                    Console.SetCursorPosition(0, 0);
                    // Clear();
                    Console.Write(number);
                    Thread.Sleep(delay);
                }
            }

        }
    }
}