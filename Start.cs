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
                        Console.ForegroundColor = ConsoleColor.DarkGray;
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
                    Modules.AddTerms();
                    break;
                case 1:
                    Modules.Identification();
                    break;
                case 2:
                    Modules.MultipleChoice();
                    break;
                case 3:;
                    Modules.ViewTerms();
                    break;
                case 4:
                    Menu.ChoosePreset();
                    break;
            }
        }
        public static void LoadPreset()
        {
            string[] Options = { "KOMFIL", "ITEC 101", "ITEC 102", "PathFit", "Exit" };
            int selectedOption = 0;
            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@"

                                ██████╗ ██████╗ ███████╗███████╗███████╗████████╗███████╗
                                ██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝╚══██╔══╝██╔════╝
                                ██████╔╝██████╔╝█████╗  ███████╗█████╗     ██║   ███████╗
                                ██╔═══╝ ██╔══██╗██╔══╝  ╚════██║██╔══╝     ██║   ╚════██║
                                ██║     ██║  ██║███████╗███████║███████╗   ██║   ███████║
                                ╚═╝     ╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝   ╚═╝   ╚══════╝
                                                         
");
                Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.DarkGray;
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
                    Library.LoadKomfilPreset();
                    Choice();
                    break;
                case 1:
                    Library.LoadITEC101Preset();
                    Choice();
                    break;
                case 2:
                    Library.LoadITEC102Preset();
                    Choice();
                    break;
                case 3:
                    Library.LoadPathfitPreset();
                    Choice();
                    break;
                case 4:
                    Menu.ChoosePreset();
                    break;
            }

        }
    
        public static void InefficientTerms()
        {
            if (Library.Terms.Count == 0 || Library.Definition.Count == 0 || Library.Terms.Count != Library.Definition.Count)
            {

                    Console.Clear();
                    Console.WriteLine("Insufficient flashcards or mismatch between terms and definitions.");
                    Console.WriteLine("Add flashcards first.");
                    Console.WriteLine("Press any key to go back...");
                    Console.ReadKey(true);

                    Choice();

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
    }
}
