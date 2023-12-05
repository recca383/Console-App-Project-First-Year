using Console_App_Project_First_Year;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
class Program
{

    public static void Main()
    {
    /*Interface:
        ConsoleKeyInfo UI;
        do
        {
            Console.Clear();
            PrintInCenter("Enter to continue");
            
            UI = Console.ReadKey();
        } while( (ConsoleModifiers.Alt != 0)&& (UI.Key != ConsoleKey.Enter));
        goto Load;
       
        
        *//*{ goto Load; }
        else goto Interface;*//*

        LoadingScreen();*/



        ConsoleKeyInfo exit;
        bool run = true;
    Load:
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
            Console.WriteLine("Welcome!!");
            PrintInCenterLine(@"
╔════════════════════════════════╗
║     Welcome Fellow Student!!   ║
╚════════════════════════════════╝");
            PrintInCenterLine("1. Add Terms");
            PrintInCenterLine("2. Identification Quiz");
            PrintInCenterLine("3. Multiple Choice");
            PrintInCenterLine("4. View Terms");
            PrintInCenterLine("5. Exit");
                     
            PrintInCenter("\nEnter the number beside your choice to continue: ");


            byte MenuInput = 0;

            try
            {
                MenuInput = Convert.ToByte(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.Clear();
                Console.WriteLine("Invalid Input! Try Again \nPress Any Key To go back to Start");
                Console.ReadKey(true);
                goto Start;

            }
            catch (Exception e)
            {

            }


            switch (MenuInput)
            {

                case 1:
                    goto AddTerms;
                case 2:
                    goto Identification;
                case 3:
                    goto Multiple_Choice;
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

            } while (exit.Key != ConsoleKey.Q);
            
            goto Start;

        //Identification Module
        Identification:
            
            if (Terms.Count == 0 || Definition.Count == 0 || Terms.Count != Definition.Count)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Insufficient flashcards or mismatch between terms and definitions.");
                    Console.WriteLine("Add flashcards first.");
                    Console.WriteLine("Press Escape to go back to Start...");
                    exit = Console.ReadKey();
                } while (exit.Key != ConsoleKey.Escape);
                goto Start;

            }

            Console.Clear();
            t = Terms.ToArray();
            
            do
            {
                int points = 0;
                int totalQuestions = t.Length;
                HashSet<int> askedQuestions = new HashSet<int>();

                for (int question = 0; question <= t.Length-1; question++) {
                    
                    Console.Clear();
                    Console.WriteLine($"Points: {points}/{t.Length}");                 
                    Random R = new Random();
                    
                    int picker;
                    do
                    {
                        picker = R.Next(0, totalQuestions);
                    } while (askedQuestions.Contains(picker));
                    
                    askedQuestions.Add(picker);
                    
                    Console.Write($"{question + 1}. {Definition[picker]}: ");                                        
                    
                    string UserAnswer = Console.ReadLine().ToUpper();

                    string Answer = Terms[picker];
                    if (UserAnswer == Answer.ToUpper()) 
                    { 
                        Console.WriteLine("Great!");
                        points++;
                        Console.ReadKey();
                    }
                    else
                    {                       
                        Console.WriteLine($"Incorrect, Better luck next time.\nThe correct answer is: {Answer}");
                        Console.ReadKey();                        
                    }
                }
                Console.Clear();
                Console.WriteLine($"Quiz completed! You scored {points} out of {Definition.Count}.\n");
                Console.WriteLine("Average: {0} ", Average(points, Definition.Count));
                Console.WriteLine("Press Escape to go back to Start...");
                exit = Console.ReadKey();
            } while (exit.Key != ConsoleKey.Escape);
            goto Start;

        // Multiple Choice Module
        Multiple_Choice:
            Console.Clear();


            if (Terms.Count == 0 || Definition.Count == 0 || Terms.Count != Definition.Count)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Insufficient flashcards or mismatch between terms and definitions.");
                    Console.WriteLine("Add flashcards first.");
                    Console.WriteLine("Press Escape to go back to Start...");
                    exit = Console.ReadKey();
                } while (exit.Key != ConsoleKey.Escape);
                goto Start;

            }

            Console.WriteLine("Quiz Time!");
            int score = 0;
            t = Terms.ToArray();
            Random random = new Random();

            do
            {
            repeat:
                Console.Write("Input the number of Choices you want: ");
                int numChoice;

                bool inputChoice = int.TryParse(Console.ReadLine(), out numChoice);
                
                HashSet<int> currentDefinition = new HashSet<int>();
                int totalQuestions = t.Length;

                if (inputChoice && numChoice >= 1 && numChoice <= (Terms.Count))


                {
                    for (int question = 0; question < Terms.Count; question++)
                    {
                        Console.Clear();
                        int picker;
                        do
                        {
                            picker = random.Next(0, totalQuestions);
                        } while (currentDefinition.Contains(picker));

                        List<string> options = new List<string>();
                        string correctAnswer = Terms[picker];
                        options.Add(correctAnswer);
                                               
                        currentDefinition.Add(picker);

                        List<string> otherTerms = new List<string>(Terms);
                        otherTerms.Remove(correctAnswer);
                        Randomize(otherTerms);

                        otherTerms = otherTerms.GetRange(0, Math.Min(numChoice - 1, otherTerms.Count)); // determines the number of choices

                        options.AddRange(otherTerms);
                        Randomize(options);

                        Console.WriteLine($"{question + 1}. {Definition[picker]}\n");

                        for (int j = 0; j < options.Count; j++)
                        {

                            Console.WriteLine($"{j + 1}. {options[j]}");
                        }

                        int Choice;
                        Console.Write("Input the number of the answer: ");
                        bool validInput = int.TryParse(Console.ReadLine(), out Choice);

                        if (validInput && Choice >= 1 && Choice <= options.Count)
                        {
                            string userAnswer = options[Choice - 1];

                            if (userAnswer == correctAnswer)
                            {
                                Console.WriteLine("Correct Answer!");
                                score++;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine($"Incorrect, Better luck next time.\nThe correct answer is: {correctAnswer}");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Moving to the next question.");
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input.");
                    goto repeat;
                }

                Console.Clear();
                Console.WriteLine($"Quiz completed! You scored {score} out of {Definition.Count}.\n");
                Console.WriteLine("Average: {0} ",Average(score, Definition.Count));
                Console.WriteLine("Press Escape to go back to Start...");
                exit = Console.ReadKey();
            } while (exit.Key != ConsoleKey.Escape);
            goto Start;


        //View Terms Module
        ViewTerms:

            if (Terms.Count == 0 || Definition.Count == 0 || Terms.Count != Definition.Count)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("No flashcards have been inputed.");
                    Console.WriteLine("Add flashcards first.");
                    Console.WriteLine("Press Escape to go back to Start...");
                    exit = Console.ReadKey();
                } while (exit.Key != ConsoleKey.Escape);
                goto Start;

            }

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

        float averageScore = (points * 50)/total + 50;
        string feedback = " ";
        // Display result
        Console.WriteLine($"Your average score is {averageScore}%");

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
  

    static void Randomize<T>(List<T> list)
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
            

        Console.WriteLine("\n\n\tPress Any Key to Continue...");
        Console.ReadKey();

    }
        static void PrintInCenterLine (string text)
    {
        int center = Console.WindowWidth / 2 - 20;
        for (int i = 0; i < center; i++)
        {
            Console.Write(" ");
        }
        Console.Write(text);
        Console.WriteLine();
    }
    static void PrintInCenter(string text)
    {
        int center = Console.WindowWidth/2 - 20;
        for (int i = 0; i < center; i++)
        {
            Console.Write(" ");
        }
        Console.Write(text);
        
    }
}      
