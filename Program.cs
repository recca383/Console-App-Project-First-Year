using Console_App_Project_First_Year;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
class Program
{
        
    public static void Main()
    {

        LoadingScreen();

        ConsoleKeyInfo exit;
        bool run = true;
        do
        {
            //Start Menu
            //Loading Screen
            List<string> Terms = new List<string>();
            List<string> Definition = new List<string>();
            string[] t;

        

        //Start Menu
        Start:
            Console.Clear();
            Console.WriteLine("Welcome Fellow Student!!");
            Console.WriteLine("1. Add Terms \n2. Identification Quiz \n3. Multiple Choice \n4. View Terms \n5. Exit");
            Console.Write("\nEnter the number beside your choice to continue: ");
            
            byte response = Convert.ToByte(Console.ReadLine());
            
            switch (response)
            {

                case 1:
                    goto AddTerms;
                case 2:
                    goto Identification;
                case 3:
                    break;
                case 4:
                    goto ViewTerms;
                case 5:
                    goto Exit;

            }
        
        //Add Terms Module
        AddTerms:

            do
            {

                Console.Clear();
                Console.Write("Term: ");
                string insertTerm = Console.ReadLine();
                Terms.Add(insertTerm);
                Console.Write("Definition: ");
                string insertDefinition = Console.ReadLine();
                Definition.Add(insertDefinition);

                Console.WriteLine("Press Escape to go back to Main Menu");
                exit = Console.ReadKey();

            } while (exit.Key != ConsoleKey.Escape);
            
            goto Start;

        //Identification Module
        Identification:
            Console.Clear();
            t = Terms.ToArray();
            do
            {
                int points = 0;
                int picker;
                for (int question = 0; question <= t.Length-1; question++) {
                    

                    Console.Clear();
                    Console.WriteLine($"Points: {points}/{t.Length}");
                    Random R = new Random();
                    picker = R.Next(0,t.Length-1);
                    Console.Write($"{question+1}. {Definition[picker]}: ");
                    
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == Terms[picker].ToUpper()) { 
                        Console.WriteLine("Great!");
                        points+=1;
                    } Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine(Average(points, t.Length));
                Console.WriteLine("Press Escape to go back to Start...");

                exit = Console.ReadKey();
            } while (exit.Key != ConsoleKey.Escape);

        //View Terms Module
        ViewTerms:
            Console.Clear();
            Console.WriteLine("Press any key to go back...");
            t = Terms.ToArray();
            
            for (int i = 0; i <= t.Length-1; i++)
                {
                    Console.Write($"{i + 1}. {Terms[i]} - {Definition[i]}\n");
                }
            
            Console.ReadKey();
            goto Start;

        //Exit Module
        Exit:
            Console.Clear();
            Console.WriteLine("Thank you for reviewing with me!!");
            run = false;
            Console.ReadKey();

        } while (run);
    }
    static string Average(int points, int total)
    {

        float averageScore = (points / total) * 100;
        string feedback = " ";
        // Display result
        Console.WriteLine($"Your average score is {averageScore * 100}%");

        switch (averageScore)
        {
            case var _ when averageScore >= 90:
                feedback += "Excellent!";
                break;
            case var _ when averageScore >= 70 && averageScore < 90:
                feedback += "Good.";
                break;
            case var _ when averageScore >= 50 && averageScore < 70:
                feedback += "Fair.";
                break;
            default:
                feedback += "Poor.";
                break;
 
        }
        return feedback;
    }
    /*static string Responses(bool Correct) 
    {
        string feedback = " ";

        string[] GoodFeedback = {"Nice!!", "Good One" };
        string[] BadFeedback = { "Try Again", "Awww... sad" };

        Random rnd = new Random();

        if (Correct)
        return feedback; 
    }*/

    static void LoadingScreen() {



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

        LoadingScreenAnimation.AnimateNumbers(numbers, 1, 400);
        Console.CursorVisible = true;
            

        Console.WriteLine("\n\n\tPress Enter to Start");
        Console.ReadKey();

    }
}      