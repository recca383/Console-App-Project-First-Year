using Console_App_Project_First_Year;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    internal class Menu
    {
        public static void ChoosePreset()
        {

            string[] Options = { "New Reviewer", "Saved Preset", "Exit" };
            int selectedOption = 0;
            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"
       
                ███████╗██████╗ ███████╗███████╗ ██████╗      ██████╗  ███████╗ ██╗   ██╗     ██╗   ██╗
                ██╔════╝██╔══██╗██╔════╝██╔════╝ ██╔══██╗     ██╔══██╗ ██╔════╝ ██║   ██║     ██║   ██║
                ███████╗██████╔╝█████╗  █████╗   ██║  ██║     ██████╔╝ █████╗   ██║   ██║     ██║   ██║
                ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ██║  ██║     ██╔══██╗ ██╔══╝   ╚██╗ ██╔╝     ██║   ██║
                ███████║██║     ███████╗███████╗ ██████╔╝     ██║  ██║ ███████╗  ╚████╔╝      ╚██████╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ 

");
                Console.ResetColor();
                // Center the instruction centered at the top

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
                    Start.Choice();
                    break;
                case 1:
                    Start.LoadPreset();
                    break;
                case 2:
                    ExitScreen.ThankYou();
                    break;
            }

        }
         
        public static int Indexer()
        {
            string[] Options = { "Continue", "Exit" };
            int selectedOption = 0;
            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();

                int windowWidth = Console.WindowWidth;

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
            return selectedOption;

        }
        public static void ContinueOrExitAddTerms()
        {

            switch (Indexer())
            {
                case 0:
                    Modules.AddTerms();
                    break;
                case 1:
                    Start.Choice();
                    break;
                

            }
        }
        public static void ContinueOrExitIdentification()
        {

            switch (Indexer())
            {
                case 0:
                    Modules.Identification();
                    break;
                case 1:
                    Start.Choice();
                    break;


            }
        }

        public static void ContinueOrExitMultiChoice()
        {

            switch (Indexer())
            {
                case 0:
                    Modules.MultipleChoice();
                    break;
                case 1:
                    Start.Choice();
                    break;


            }
        }
        public static void Blink(string text, int blinkCount = 5, int onTime = 500)
        {
            Console.CursorVisible = false;
            for (int i = 0; i < blinkCount; i++)
            {
                Console.WriteLine(text);
                Thread.Sleep(onTime);
                Console.Clear();
            }
            Console.WriteLine(text);
            Console.CursorVisible = true;
        }
    }
}
