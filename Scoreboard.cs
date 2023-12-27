using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    internal class Scoreboard
    {
        public DateTime DateTime { get; set; }
        public int Score { get; set; }
        public Scoreboard(string mode, DateTime DateTime, int Score) 
        {
            this.DateTime = DateTime;
            this.Score = Score;
        }
    }
}
