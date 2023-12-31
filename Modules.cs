using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console_App_Project_First_Year
{
    internal class Modules
    {
        private static ConsoleKeyInfo exit;
        private static string[] t;
        public static void AddTerms()
        {

            Console.Clear();

            string insertTerm;
            string insertDefinition;
            do
            {
                Print.InCenterLine("Input A Term");
                Console.WriteLine("\n\u001b[93m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
                Print.InCenter("Term: ");
                insertTerm = Console.ReadLine();

                if (string.IsNullOrEmpty(insertTerm))
                {
                    Print.InCenterLine("Invalid input: Don't Leave it Blank");
                    Console.ReadKey();
                }
                else Library.Terms.Add(insertTerm);
                Console.Clear();

            } while (insertTerm == string.Empty);

            do
            {
                Print.InCenterLine("Input A Definition");
                Console.WriteLine("\n\u001b[93m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
                Print.InCenter("Definition: ");
                insertDefinition = Console.ReadLine();

                if (string.IsNullOrEmpty(insertDefinition))
                {
                    Print.InCenterLine("Invalid input: Don't Leave it Blank");
                    Console.ReadKey();
                }
                else Library.Definition.Add(insertDefinition);
                Console.Clear();

            } while (insertDefinition == string.Empty);

            Menu.ContinueOrExitAddTerms();

            Program.Main();
        }
        public static void Identification()
        {
            Console.CursorVisible = true;
            Start.InefficientTerms();

            Console.Clear();

            t = Library.Terms.ToArray();
            Print.InCenterLine("Quiz Time!");
        repeat2:
            Console.WriteLine("\n\u001b[95m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
            Print.InCenter("Input how many seconds [5 - 60]: ");
            int TimerChoice;
            bool inputTimer = int.TryParse(Console.ReadLine(), out TimerChoice);

            int points = 0;
            int totalQuestions = t.Length;
            HashSet<int> askedQuestions = new HashSet<int>();
            if (inputTimer && TimerChoice >= 5 && inputTimer && TimerChoice <= 60)
            {
                for (int question = 0; question <= t.Length - 1; question++)
                {

                    Console.Clear();
                    Console.CursorVisible = true;
                    Print.InCenterLine($"You have {TimerChoice} seconds to answer the question");

                    bool timeIsUp = false;
                    // Create a timer with the specified duration
                    Timer timer = new Timer(state =>
                    {
                        Console.CursorVisible = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Menu.Blink(@"
                            ████████╗██╗███╗   ███╗███████╗███████╗    ██╗   ██╗██████╗ ██╗
                            ╚══██╔══╝██║████╗ ████║██╔════╝██╔════╝    ██║   ██║██╔══██╗██║
                               ██║   ██║██╔████╔██║█████╗  ███████╗    ██║   ██║██████╔╝██║
                               ██║   ██║██║╚██╔╝██║██╔══╝  ╚════██║    ██║   ██║██╔═══╝ ╚═╝
                               ██║   ██║██║ ╚═╝ ██║███████╗███████║    ╚██████╔╝██║     ██╗
                               ╚═╝   ╚═╝╚═╝     ╚═╝╚══════╝╚══════╝     ╚═════╝ ╚═╝     ╚═╝                                                                   
", 2, 100);
                        Console.ResetColor();
                        Print.InCenterLine("Press Enter to Continue");
                        timeIsUp = true;

                    }, null, TimerChoice * 1000, Timeout.Infinite);

                    Random R = new Random();

                    int picker;
                    do
                    {
                        picker = R.Next(0, totalQuestions);
                    } while (askedQuestions.Contains(picker));

                    askedQuestions.Add(picker);

                    Console.WriteLine($"\n{question + 1}. {Library.Definition[picker]}");
                    Console.WriteLine("\n\u001b[95m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
                    Console.Write("Enter your answer here: ");
                    string UserAnswer = Console.ReadLine().ToUpper();
                   
                    string Answer = Library.Terms[picker];
                    timer.Change(Timeout.Infinite, Timeout.Infinite);
                    if (timeIsUp)
                    {
                        continue; // Skip the rest of the loop iteration for this question
                    }
                    Console.WriteLine("\n\u001b[95m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
                    if (UserAnswer == Answer.ToUpper())
                    {
                        Console.CursorVisible = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@"
                  _____                             __         ___                                  __
                 / ___/ ___   ____  ____ ___  ____ / /_       / _ |  ___   ___ _    __ ___   ____  / /
                / /__  / _ \ / __/ / __// -_)/ __// __/      / __ | / _ \ (_-<| |/|/ // -_) / __/ /_/ 
                \___/  \___//_/   /_/   \__/ \__/ \__/      /_/ |_|/_//_//___/|__,__/ \__/ /_/   (_)                                                                                                                                                                                                          
");
                        Console.ResetColor();
                        points++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.CursorVisible = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
               ____                                        __         ___                                  __
              /  _/  ___  ____ ___   ____  ____ ___  ____ / /_       / _ |  ___   ___ _    __ ___   ____  / /
             _/ /   / _ \/ __// _ \ / __/ / __// -_)/ __// __/      / __ | / _ \ (_-<| |/|/ // -_) / __/ /_/ 
            /___/  /_//_/\__/ \___//_/   /_/   \__/ \__/ \__/      /_/ |_|/_//_//___/|__,__/ \__/ /_/   (_)                                                                                                                                                                                                                                                                                                    
");
                        Console.ResetColor();
                        Print.InCenterLine($"The correct answer is: {Answer}");
                        Console.ReadKey();
                    }
                }                
            }
            else
            {
                Console.Clear();
                Print.InCenterLine("Quiz Time!");
                Print.InCenterLine("Invalid input.");
                goto repeat2;
            }
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
 ██████╗ ██╗   ██╗██╗███████╗     ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗     ███████╗████████╗███████╗██████╗ ██╗
██╔═══██╗██║   ██║██║╚══███╔╝    ██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║     ██╔════╝╚══██╔══╝██╔════╝██╔══██╗██║
██║   ██║██║   ██║██║  ███╔╝     ██║     ██║   ██║██╔████╔██║██████╔╝██║     █████╗     ██║   █████╗  ██║  ██║██║
██║▄▄ ██║██║   ██║██║ ███╔╝      ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║     ██╔══╝     ██║   ██╔══╝  ██║  ██║╚═╝
╚██████╔╝╚██████╔╝██║███████╗    ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ███████╗███████╗   ██║   ███████╗██████╔╝██╗
 ╚══▀▀═╝  ╚═════╝ ╚═╝╚══════╝     ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚══════╝╚══════╝   ╚═╝   ╚══════╝╚═════╝ ╚═╝                                                                                                                
");
            Console.ResetColor();
            Console.WriteLine($"Quiz completed! You scored {points} out of {Library.Definition.Count}.\n");
            Console.WriteLine("Average: {0} ", Average.Base50(points, Library.Definition.Count));            
            Console.WriteLine("Press any key to continue *--->");
            Console.ReadKey(true);

            Menu.ContinueOrExitIdentification();

        }
        public static void MultipleChoice()
        {
            Console.Clear();
            Console.CursorVisible = true;
            Start.InefficientTerms();
            Start.InefficietTermsForMultipleChoice();
            
            Print.InCenterLine("Quiz Time!");
            int score = 0;
            t = Library.Terms.ToArray();
            Random random = new Random();

        repeat:
            Console.WriteLine("\n\u001b[36m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
            Print.InCenter("Input the number of Choices you want: ");
            int numChoice;
            bool inputChoice = int.TryParse(Console.ReadLine(), out numChoice);
            Console.Clear();
            Print.InCenterLine("Quiz Time!");
        repeat2:

            Console.WriteLine("\n\u001b[36m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
            Print.InCenter("Input how many seconds you want to answer each question [5 - 60]: ");
            int TimerChoice;
            bool inputTimer = int.TryParse(Console.ReadLine(), out TimerChoice);
          
            HashSet<int> currentDefinition = new HashSet<int>();
            int totalQuestions = t.Length;
            Console.CursorVisible = false;

            if (inputChoice && numChoice >= 3 && numChoice <= (Library.Terms.Count))
            {
                if (inputTimer && TimerChoice >= 5 && inputTimer && TimerChoice <= 60)
                {
                    for (int question = 0; question < Library.Terms.Count; question++)
                    {
                        Console.Clear();
                        Print.InCenterLine($"You have {TimerChoice} seconds to answer the question");

                        bool timeIsUp = false;
                        // Create a timer with the specified duration
                        Timer timer = new Timer(state =>
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Menu.Blink(@"
                            ████████╗██╗███╗   ███╗███████╗███████╗    ██╗   ██╗██████╗ ██╗
                            ╚══██╔══╝██║████╗ ████║██╔════╝██╔════╝    ██║   ██║██╔══██╗██║
                               ██║   ██║██╔████╔██║█████╗  ███████╗    ██║   ██║██████╔╝██║
                               ██║   ██║██║╚██╔╝██║██╔══╝  ╚════██║    ██║   ██║██╔═══╝ ╚═╝
                               ██║   ██║██║ ╚═╝ ██║███████╗███████║    ╚██████╔╝██║     ██╗
                               ╚═╝   ╚═╝╚═╝     ╚═╝╚══════╝╚══════╝     ╚═════╝ ╚═╝     ╚═╝                                                                   
", 2, 100);
                            Console.ResetColor();
                            Print.InCenterLine("Press Enter to Continue");
                            timeIsUp = true;

                        }, null, TimerChoice * 1000, Timeout.Infinite);

                        int picker;
                        do
                        {
                            picker = random.Next(0, totalQuestions);
                        } while (currentDefinition.Contains(picker));

                        List<string> options = new List<string>();
                        string correctAnswer = Library.Terms[picker];
                        options.Add(correctAnswer);

                        currentDefinition.Add(picker);

                        List<string> otherTerms = new List<string>(Library.Terms);
                        otherTerms.Remove(correctAnswer);
                        Start.Randomize(otherTerms);

                        otherTerms = otherTerms.GetRange(0, Math.Min(numChoice - 1, otherTerms.Count)); // determines the number of choices

                        options.AddRange(otherTerms);
                        Start.Randomize(options);

                        Console.WriteLine($"\n{question + 1}. {Library.Definition[picker]}");
                        Console.WriteLine("\n\u001b[36m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
                        int selectedOption = 0;
                        int currentTop = Console.CursorTop;

                        ConsoleKeyInfo keyInfo;
                        do
                        {
                            Console.SetCursorPosition(0, currentTop);

                            for (int i = 0; i < options.Count; i++)
                            {
                                string currentOption = $"{Convert.ToChar(97 + i)}. {options[i]}";
                                if (i == selectedOption)
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                }

                                Console.WriteLine($"{currentOption}");
                            }
                            Console.ResetColor();

                            keyInfo = Console.ReadKey(true);

                            if (keyInfo.Key == ConsoleKey.UpArrow)
                            {
                                selectedOption--;
                                if (selectedOption < 0)
                                {
                                    selectedOption = options.Count - 1;
                                }
                            }
                            else if (keyInfo.Key == ConsoleKey.DownArrow)
                            {
                                selectedOption++;
                                if (selectedOption >= options.Count)
                                {
                                    selectedOption = 0;
                                }
                            }
                        } while (keyInfo.Key != ConsoleKey.Enter);
                        timer.Change(Timeout.Infinite, Timeout.Infinite);
                        
                        if (timeIsUp)
                        {                      
                            continue; // Skip the rest of the loop iteration for this question
                        }
                        int choiceIndex = selectedOption;
                        string userAnswer = options[choiceIndex];

                        Console.WriteLine("\n\u001b[36m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
                        if (userAnswer == correctAnswer)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"
                  _____                             __         ___                                  __
                 / ___/ ___   ____  ____ ___  ____ / /_       / _ |  ___   ___ _    __ ___   ____  / /
                / /__  / _ \ / __/ / __// -_)/ __// __/      / __ | / _ \ (_-<| |/|/ // -_) / __/ /_/ 
                \___/  \___//_/   /_/   \__/ \__/ \__/      /_/ |_|/_//_//___/|__,__/ \__/ /_/   (_)                                                                                                                                                                                                          
");
                            Console.ResetColor();
                            score++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"
               ____                                        __         ___                                  __
              /  _/  ___  ____ ___   ____  ____ ___  ____ / /_       / _ |  ___   ___ _    __ ___   ____  / /
             _/ /   / _ \/ __// _ \ / __/ / __// -_)/ __// __/      / __ | / _ \ (_-<| |/|/ // -_) / __/ /_/ 
            /___/  /_//_/\__/ \___//_/   /_/   \__/ \__/ \__/      /_/ |_|/_//_//___/|__,__/ \__/ /_/   (_)                                                                                                                                                                                                                                                                                                    
");
                            Console.ResetColor();
                            Print.InCenterLine($"The correct answer is: {correctAnswer}");
                        }
                        
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Print.InCenterLine("Quiz Time!");
                    Print.InCenterLine("Invalid input.");
                    goto repeat2;
                }
            }
            else
            {
                Console.Clear();
                Print.InCenterLine("Quiz Time!");
                Print.InCenterLine("Invalid input.");
                goto repeat;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
 ██████╗ ██╗   ██╗██╗███████╗     ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗     ███████╗████████╗███████╗██████╗ ██╗
██╔═══██╗██║   ██║██║╚══███╔╝    ██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║     ██╔════╝╚══██╔══╝██╔════╝██╔══██╗██║
██║   ██║██║   ██║██║  ███╔╝     ██║     ██║   ██║██╔████╔██║██████╔╝██║     █████╗     ██║   █████╗  ██║  ██║██║
██║▄▄ ██║██║   ██║██║ ███╔╝      ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║     ██╔══╝     ██║   ██╔══╝  ██║  ██║╚═╝
╚██████╔╝╚██████╔╝██║███████╗    ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ███████╗███████╗   ██║   ███████╗██████╔╝██╗
 ╚══▀▀═╝  ╚═════╝ ╚═╝╚══════╝     ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚══════╝╚══════╝   ╚═╝   ╚══════╝╚═════╝ ╚═╝                                                                                                                
");
            Console.ResetColor();
            Console.WriteLine($"You scored {score} out of {Library.Definition.Count}.\n");
            Console.WriteLine("Average: {0} ", Average.Base50(score, Library.Definition.Count));
            Console.WriteLine("\nPress any key to continue *--->");
            Console.ReadKey(true);
            Menu.ContinueOrExitMultiChoice();
        }
        public static void ViewTerms ()
        {

            Console.Clear();
            Start.InefficientTerms();
            Console.WriteLine("Press any key to go back...");
            t = Library.Terms.ToArray();

            for (int i = 0; i <= t.Length - 1; i++)
            {
                Console.WriteLine($"{i + 1}. \u001b[93m{Library.Terms[i]}\u001b[0m");
                Console.WriteLine($"{Library.Definition[i]}");
                Console.WriteLine("\n\u001b[93m═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════\u001b[0m\n");
            }
           
            Console.ReadKey(true);
            Start.Choice();

        }        
    }
}
