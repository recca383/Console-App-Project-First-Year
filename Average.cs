using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    internal class Average
    {
        public static string Base50(int points, int total)
        {

            float averageScore = (points * 50) / total + 50;
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

    }
}
