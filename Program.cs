using Console_App_Project_First_Year;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
public class Program
{

    public static void Main()
    {
        MainPreset();
    }

    public static void MainPreset()
    {
        string[] Options = { "New Reviewer", "Saved Preset", "Exit" };
        int selectedOption = 0;
        ConsoleKeyInfo keyInfo;

        do
        {
            Console.Clear();
            Console.WriteLine(@"
       
                ███████╗██████╗ ███████╗███████╗ ██████╗      ██████╗  ███████╗ ██╗   ██╗     ██╗   ██╗
                ██╔════╝██╔══██╗██╔════╝██╔════╝ ██╔══██╗     ██╔══██╗ ██╔════╝ ██║   ██║     ██║   ██║
                ███████╗██████╔╝█████╗  █████╗   ██║  ██║     ██████╔╝ █████╗   ██║   ██║     ██║   ██║
                ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ██║  ██║     ██╔══██╗ ██╔══╝   ╚██╗ ██╔╝     ██║   ██║
                ███████║██║     ███████╗███████╗ ██████╔╝     ██║  ██║ ███████╗  ╚████╔╝      ╚██████╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ 

");

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
                Start.Menu();
                Start.Choice();
                break;
            case 1:
                Console.CursorVisible = true;
                Start.LoadPreset();
                break;
            case 2:
                Console.CursorVisible = true;
                ExitReviewer();
                break;
        }

        static void ExitReviewer()
        {
            Console.ReadKey(true);
        }

        //bool run = true;
        ////LoadingScreen.Animation();

        ////Palagyan ulit dito nung parang laro na choices
        ////yung nagkakahighlight ganun
        //Console.Write("New reviewer or Load Preset? : ");

        //string response = Console.ReadLine();

        //if (response == "Load")
        //{
        //    Start.LoadPreset();
        //}

        //do {

        //    Start.Menu();
        //    Start.Choice();




        //} while (run);
        //Start.Exit();
    }


}

   


    