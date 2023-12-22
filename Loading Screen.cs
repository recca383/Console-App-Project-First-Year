using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    class LoadingScreen
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
        public static void Animation()
        {



            string programmingQuote = @"
        
        ███████╗██████╗ ███████╗███████╗ ██████╗      ██████╗  ███████╗ ██╗   ██╗     ██╗   ██╗
        ██╔════╝██╔══██╗██╔════╝██╔════╝ ██╔══██╗     ██╔══██╗ ██╔════╝ ██║   ██║     ██║   ██║
        ███████╗██████╔╝█████╗  █████╗   ██║  ██║     ██████╔╝ █████╗   ██║   ██║     ██║   ██║
        ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ██║  ██║     ██╔══██╗ ██╔══╝   ╚██╗ ██╔╝     ██║   ██║
        ███████║██║     ███████╗███████╗ ██████╔╝     ██║  ██║ ███████╗  ╚████╔╝      ╚██████╔╝
        ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ 

";

            for (int i = 0; i < programmingQuote.Length; i++)
            {
                Console.Write(programmingQuote[i]);
                Thread.Sleep(10);
            }
            Console.CursorVisible = false;

            string[] numbers = {@"







        Loading o o o
        ╚════════════════════════╝",
                    @"           







        Loading o    
        ████═════════════════════╝",
                    @"







        Loading o o  
        ████████═════════════════╝",
                    @"







        Loading o o o
        ██████████═══════════════╝",
                    @"







        Loading o    
        ██████████████═══════════╝",
                    @"







        Loading o o  
        ██████████████████═══════╝",
                    @"







        Loading o o o
        ██████████████████████═══╝",
                    @"







        Loading o o o
        ██████████████████████████",};

            AnimateNumbers(numbers, 1, 400);
            Console.CursorVisible = true;


            Console.WriteLine("\n\n\tPress Any Key to Continue...");
            Console.ReadKey();

        }
    }
}