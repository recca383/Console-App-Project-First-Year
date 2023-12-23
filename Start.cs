using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    internal class Start
    {
        private static ConsoleKeyInfo exit;

        public static void Menu ()
        {
            Console.Clear();
            Print.InCenterLine(@"╔════════════════════════════════╗");
            Print.InCenterLine(@"║     Welcome Fellow Student!!   ║");
            Print.InCenterLine(@"╚════════════════════════════════╝");
            Print.InCenterLine("1. Add Terms");
            Print.InCenterLine("2. Identification Quiz");
            Print.InCenterLine("3. Multiple Choice");
            Print.InCenterLine("4. View Terms");
            Print.InCenterLine("5. Exit");

            Print.InCenter("Enter the number beside your choice to continue: ");


        }
        public static void Choice ()
        {
            byte MenuInput = 0;

            try
            {

                MenuInput = Convert.ToByte(Console.ReadLine());
                if (!(MenuInput > 0 && MenuInput <= 5))
                {
                    Print.InCenter("Invalid input: refer to the choices above");
                    Console.ReadKey();
                }

            }
            catch (FormatException)
            {
                Console.Clear();
                Print.InCenterLine("Invalid Input! Try Again \nPress Any Key To go back to Start");
                Console.ReadKey(true);

            }
            catch (Exception e)
            {
                Print.InCenterLine(e.Message);
            }


            switch (MenuInput)
            {

                case 1:
                    Modules.AddTerms();
                    break;
                case 2:
                    Modules.Identification();
                    break;
                case 3:
                    Modules.MultipleChoice();
                    break;
                case 4:
                    Modules.ViewTerms();
                    break;
                case 5:
                    Exit();
                    break;

            }
        }
        public static void LoadPreset()
        {
            Print.InCenter("1. Komfil");
            Print.InCenter("2. Itec101");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    Library.LoadKomfilPreset();
                    break; 
                case 2:
                    Library.LoadITEC101Preset();
                    break;
                case 3:
                    Library.LoadITEC102Preset();
                    break;
                case 4:
                    Library.LoadPathfitPreset();
                    break;

            }
        }
        public static void InefficientTerms()
        {
            if (Library.Terms.Count == 0 || Library.Definition.Count == 0 || Library.Terms.Count != Library.Definition.Count)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Insufficient flashcards or mismatch between terms and definitions.");
                    Console.WriteLine("Add flashcards first.");
                    Console.WriteLine("Press Escape to go back to Start...");
                    exit = Console.ReadKey();
                } while (exit.Key != ConsoleKey.Escape);


            }

        }
        public static void Randomize<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public static void Exit() 
        {
            Console.Clear();
            Console.WriteLine("Thank you for reviewing with me!!");
            Console.ReadKey();
        }

    }
}
