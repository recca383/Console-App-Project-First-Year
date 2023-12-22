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
            /*Console.Clear();
            Console.WriteLine("Welcome!!");
            Print.InCenterLine(@"╔════════════════════════════════╗");
            Print.InCenterLine(@"║     Welcome Fellow Student!!   ║");
            Print.InCenterLine(@"╚════════════════════════════════╝");
            Print.InCenterLine("1. Add Terms");
            Print.InCenterLine("2. Identification Quiz");
            Print.InCenterLine("3. Multiple Choice");
            Print.InCenterLine("4. View Terms");
            Print.InCenterLine("5. Exit");

            Print.InCenter("Enter the number beside your choice to continue: ");*/


        }
        public static void Choice ()
        {

            string[] Options = { "Add Terms", "Identification Quiz", "Multiple Choice Quiz", "View Terms", "Exit" };
            int selectedOption = 0;
            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();

                Console.WriteLine(@"
      _ _ _ ____ _    ____ ____ _  _ ____    ____ ____ _    _    ____ _ _ _    ____ ___ _  _ ___  ____ _  _ ___ ____ 
      | | | |___ |    |    |  | |\/| |___    |___ |___ |    |    |  | | | |    [__   |  |  | |  \ |___ |\ |  |  [__  
      |_|_| |___ |___ |___ |__| |  | |___    |    |___ |___ |___ |__| |_|_|    ___]  |  |__| |__/ |___ | \|  |  ___] 
                                                                                                               
");

                string instruction = "Use arrow keys to navigate. Press Enter to select.";
                int windowWidth = Console.WindowWidth;
                int instructionPadding = (windowWidth - instruction.Length) / 2;
                Console.WriteLine(instruction.PadLeft(instructionPadding + instruction.Length));
                Console.WriteLine("");

                for (int i = 0; i < Options.Length; i++)
                {
                    string currentOption = Options[i];
                    // Calculate padding for center alignment
                    int padding = (windowWidth - currentOption.Length) / 2;
                    // Center the options
                    string option = currentOption.PadLeft(padding + currentOption.Length);

                    if (i == selectedOption)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{option}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{option}");
                    }
                }
                Console.ResetColor();

                // Console.Beep();

                keyInfo = Console.ReadKey(true);

                // Update selectedOption based on arrow keys

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedOption--;
                    if (selectedOption == -1)
                    {
                        selectedOption = Options.Length - 1;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedOption++;
                    if (selectedOption == Options.Length)
                    {
                        selectedOption = 0;
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Enter);

            switch (selectedOption)
            {
                case 0:
                    Console.CursorVisible = true;
                    Modules.AddTerms();
                    break;
                case 1:
                    Console.CursorVisible = true;
                    Modules.Identification();
                    break;
                case 2:
                    Console.CursorVisible = true;
                    Modules.MultipleChoice();
                    break;
                case 3:
                    Console.CursorVisible = true;
                    Modules.ViewTerms();
                    break;
                case 4:
                    Console.CursorVisible = true;
                    Program.Main();
                    break;
            }

            //byte MenuInput = 0;

            //try
            //{

            //    MenuInput = Convert.ToByte(Console.ReadLine());
            //    if (!(MenuInput > 0 && MenuInput <= 5))
            //    {
            //        Print.InCenter("Invalid input: refer to the choices above");
            //        Console.ReadKey();
            //    }

            //}
            //catch (FormatException)
            //{
            //    Console.Clear();
            //    Print.InCenterLine("Invalid Input! Try Again \nPress Any Key To go back to Start");
            //    Console.ReadKey(true);

            //}
            //catch (Exception e)
            //{
            //    Print.InCenterLine(e.Message);
            //}


            //switch (MenuInput)
            //{

            //    case 1:
            //        Modules.AddTerms();
            //        break;
            //    case 2:
            //        Modules.Identification();
            //        break;
            //    case 3:
            //        Modules.MultipleChoice();
            //        break;
            //    case 4:
            //        Modules.ViewTerms();
            //        break;
            //    case 5:
            //        Exit();
            //        break;

            //}
        }
        public static void LoadPreset()
        {
            string[] Options = { "KOMFIL", "ITEC 101", "ITEC 102", "PathFit", "Exit" };
            int selectedOption = 0;
            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();

                Console.WriteLine(@"

                                        ██████╗ ██████╗ ███████╗███████╗███████╗████████╗███████╗
                                        ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝╚══██╔══╝██╔════╝
                                        ██████╔╝██████╔╝█████╗  ███████╗█████╗     ██║   ███████╗
                                        ██╔═══╝ ██╔══██╗██╔══╝  ╚════██║██╔══╝     ██║   ╚════██║
                                        ██║     ██║  ██║███████╗███████║███████╗   ██║   ███████║
                                        ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝   ╚═╝   ╚══════╝
                                                         
");

                string instruction = "Use arrow keys to navigate. Press Enter to select.";
                int windowWidth = Console.WindowWidth;
                int instructionPadding = (windowWidth - instruction.Length) / 2;
                Console.WriteLine(instruction.PadLeft(instructionPadding + instruction.Length));
                Console.WriteLine("");

                for (int i = 0; i < Options.Length; i++)
                {
                    string currentOption = Options[i];
                    // Calculate padding for center alignment
                    int padding = (windowWidth - currentOption.Length) / 2;
                    // Center the options
                    string option = currentOption.PadLeft(padding + currentOption.Length);

                    if (i == selectedOption)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{option}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{option}");
                    }
                }
                Console.ResetColor();

                // Console.Beep();

                keyInfo = Console.ReadKey(true);

                // Update selectedOption based on arrow keys

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedOption--;
                    if (selectedOption == -1)
                    {
                        selectedOption = Options.Length - 1;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedOption++;
                    if (selectedOption == Options.Length)
                    {
                        selectedOption = 0;
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Enter);

            switch (selectedOption)
            {
                case 0:
                    Console.CursorVisible = true;
                    Library.LoadKomfilPreset();
                    Choice();
                    break;
                case 1:
                    Console.CursorVisible = true;
                    Library.LoadITEC101Preset();
                    Choice();
                    break;
                case 2:
                    Console.CursorVisible = true;
                    //Library.LoadITEC102Preset();
                    Choice();
                    break;
                case 3:
                    Console.CursorVisible = true;
                    //Library.LoadPathFitPreset();
                    Choice();
                    break;
                case 4:
                    Console.CursorVisible = true;
                    Program.Main();
                    break;
            }

            //Print.InCenter("1. Komfil");
            //Print.InCenter("2. ITEC 101");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //switch (choice){
            //    case 1:
            //        Library.LoadKomfilPreset();
            //        break;
            //    case 2:
            //        Library.LoadITEC101Preset();
            //        break;
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
