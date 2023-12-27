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
            Start.InefficientTerms();

            Console.Clear();

            t = Library.Terms.ToArray();

                int points = 0;
                int totalQuestions = t.Length;
                HashSet<int> askedQuestions = new HashSet<int>();

                for (int question = 0; question <= t.Length - 1; question++)
                {

                    Console.Clear();
                    Console.WriteLine($"Points: {points}/{t.Length}");
                    Random R = new Random();

                    int picker;
                    do
                    {
                        picker = R.Next(0, totalQuestions);
                    } while (askedQuestions.Contains(picker));

                    askedQuestions.Add(picker);

                    Console.Write($"{question + 1}. {Library.Definition[picker]}: ");

                    string UserAnswer = Console.ReadLine().ToUpper();

                    string Answer = Library.Terms[picker];
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
                Console.WriteLine($"Quiz completed! You scored {points} out of {Library.Definition.Count}.\n");
                Console.WriteLine("Average: {0} ", Average.Base50(points, Library.Definition.Count));

            Menu.ContinueOrExitIdentification();

        }
        public static void MultipleChoice()
        {
            Console.Clear();
            Start.InefficientTerms();
            Console.WriteLine("Quiz Time!");
            int score = 0;
            t = Library.Terms.ToArray();
            Random random = new Random();

            do
            {
            repeat:
                Console.Write("Input the number of Choices you want: ");
                int numChoice;

                bool inputChoice = int.TryParse(Console.ReadLine(), out numChoice);

                HashSet<int> currentDefinition = new HashSet<int>();
                int totalQuestions = t.Length;

                if (inputChoice && numChoice >= 1 && numChoice <= (Library.Terms.Count))


                {
                    for (int question = 0; question < Library.Terms.Count; question++)
                    {
                        Console.Clear();
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

                        Console.WriteLine($"{question + 1}. {Library.Definition[picker]}\n");

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
                Console.WriteLine($"Quiz completed! You scored {score} out of {Library.Definition.Count}.\n");
                Console.WriteLine("Average: {0} ", Average.Base50(score, Library.Definition.Count));
                Console.WriteLine("Press Escape to go back to Start...");
                exit = Console.ReadKey();
            } while (exit.Key != ConsoleKey.Escape);


        }
        public static void ViewTerms ()
        {

            Console.Clear();
            Console.WriteLine("Press any key to go back...");
            t = Library.Terms.ToArray();

            for (int i = 0; i <= t.Length - 1; i++)
            {
                Console.Write($"{i + 1}. {Library.Terms[i]} - {Library.Definition[i]}\n");
            }
           
            Console.ReadKey();
            Start.Choice();

        }

        public static void ScoreBoard()
        {

        }
    }
}
