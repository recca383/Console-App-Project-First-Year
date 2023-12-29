using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    internal class Scoreboard
    {
        public static List<string> scores{ get; private set; }
        public DateTime DateTime { get; set; }
        public int Score { get; set; }
        public Scoreboard(string mode, DateTime DateTime, int Score) 
        {
            this.DateTime = DateTime;
            this.Score = Score;

            scores.Add($"{DateTime} - {mode} : {Score} ");
        }


        public static void DisplayScores()
        {

            if (scores.Equals(null))
            {
                Console.WriteLine("EMPTY");
            }
            else
            {
                foreach (var score in scores)
                {
                    Print.InCenterLine(score);
                }

            }
            
        }

    }
}
