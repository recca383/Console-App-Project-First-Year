using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

class Program
{

    public static void Main()
    {
        //Initiation of Libraries



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
                for (int question = 0; question <= t.Length - 1; question++)
                {


                    Console.Clear();
                    Console.WriteLine($"Points: {points}/{t.Length}");
                    Random R = new Random();
                    picker = R.Next(0, t.Length - 1);
                    Console.Write($"{question + 1}. {Definition[picker]}: ");

                    string answer = Console.ReadLine().ToUpper();

                    if (answer == Terms[picker].ToUpper())
                    {
                        Console.WriteLine("Great!");
                        points += 1;
                    }
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine(Average(points, t.Length));
                Console.WriteLine("Press Escape to go back to Start...");

                exit = Console.ReadKey();
            } while (exit.Key != ConsoleKey.Escape);

        //Multiple Choice Module
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
            
            Random random = new Random();

            do
            {
            repeat:
                Console.Write("Input the number of Choices you want: ");                
                int numChoice;
                bool inputChoice = int.TryParse(Console.ReadLine(), out numChoice);


                if (inputChoice && numChoice >= 1 && numChoice <= (Terms.Count))


                {
                    for (int question = 0; question < Terms.Count; question++)
                    {
                        Console.Clear();
                        List<string> options = new List<string>();
                        string currentDefinition = Definition[question];
                        string correctAnswer = Terms[question];
                        options.Add(correctAnswer);

                        List<string> otherTerms = new List<string>(Terms);
                        otherTerms.Remove(correctAnswer);
                        Randomize(otherTerms, random);
                        
                        otherTerms = otherTerms.GetRange(0, Math.Min(numChoice - 1, otherTerms.Count)); // determines the number of choices

                        options.AddRange(otherTerms);
                        Randomize(options, random);

                        Console.WriteLine($"{question + 1}. {currentDefinition}\n");

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
                Console.WriteLine("Press Escape to go back to Start...");
                exit = Console.ReadKey();
            } while (exit.Key != ConsoleKey.Escape);
            goto Start;

     
        //View Terms Module
        ViewTerms:
            Console.Clear();
            Console.WriteLine("Press any key to go back...");
            t = Terms.ToArray();

            for (int i = 0; i <= t.Length - 1; i++)
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
        string Response = "Congrats";

        return Response;
    }
    static void Randomize<T>(List<T> list, Random random)
    {
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
