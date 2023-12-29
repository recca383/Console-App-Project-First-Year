﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    class LoadingScreen
    {

        public static void AnimateFrames(string[] frames, int repeatcount = 5, int delay = 100)
        {
            for (int i = 0; i < repeatcount; i++)
            {
                foreach (string frame in frames)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write(frame);
                    Thread.Sleep(delay);
                }
            }

        }
        public static void Animation()
        {


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorVisible = false;
            string[] frames = { @"
 
                ███████╗::::::╗ :::::::╗:::::::╗ ::::::╗      ::::::╗  :::::::╗ ::╗   ::╗     ::╗   ::╗
                ██╔════╝::╔══::╗::╔════╝::╔════╝ ::╔══::╗     ::╔══::╗ ::╔════╝ ::║   ::║     ::║   ::║
                ███████╗::::::╔╝:::::╗  :::::╗   ::║  ::║     ::::::╔╝ :::::╗   ::║   ::║     ::║   ::║
                ╚════██║::╔═══╝ ::╔══╝  ::╔══╝   ::║  ::║     ::╔══::╗ ::╔══╝   ╚::╗ ::╔╝     ::║   ::║
                ███████║::║     :::::::╗:::::::╗ ::::::╔╝     ::║  ::║ :::::::╗  ╚::::╔╝      ╚::::::╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ ", @"
            
                ███████╗██████╗ :::::::╗:::::::╗ ::::::╗      ::::::╗  :::::::╗ ::╗   ::╗     ::╗   ::╗
                ██╔════╝██╔══██╗::╔════╝::╔════╝ ::╔══::╗     ::╔══::╗ ::╔════╝ ::║   ::║     ::║   ::║
                ███████╗██████╔╝:::::╗  :::::╗   ::║  ::║     ::::::╔╝ :::::╗   ::║   ::║     ::║   ::║
                ╚════██║██╔═══╝ ::╔══╝  ::╔══╝   ::║  ::║     ::╔══::╗ ::╔══╝   ╚::╗ ::╔╝     ::║   ::║
                ███████║██║     :::::::╗:::::::╗ ::::::╔╝     ::║  ::║ :::::::╗  ╚::::╔╝      ╚::::::╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ ", @"
          
                ███████╗██████╗ ███████╗:::::::╗ ::::::╗      ::::::╗  :::::::╗ ::╗   ::╗     ::╗   ::╗
                ██╔════╝██╔══██╗██╔════╝::╔════╝ ::╔══::╗     ::╔══::╗ ::╔════╝ ::║   ::║     ::║   ::║
                ███████╗██████╔╝█████╗  :::::╗   ::║  ::║     ::::::╔╝ :::::╗   ::║   ::║     ::║   ::║
                ╚════██║██╔═══╝ ██╔══╝  ::╔══╝   ::║  ::║     ::╔══::╗ ::╔══╝   ╚::╗ ::╔╝     ::║   ::║
                ███████║██║     ███████╗:::::::╗ ::::::╔╝     ::║  ::║ :::::::╗  ╚::::╔╝      ╚::::::╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ ", @"
           
                ███████╗██████╗ ███████╗███████╗ ::::::╗      ::::::╗  :::::::╗ ::╗   ::╗     ::╗   ::╗
                ██╔════╝██╔══██╗██╔════╝██╔════╝ ::╔══::╗     ::╔══::╗ ::╔════╝ ::║   ::║     ::║   ::║
                ███████╗██████╔╝█████╗  █████╗   ::║  ::║     ::::::╔╝ :::::╗   ::║   ::║     ::║   ::║
                ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ::║  ::║     ::╔══::╗ ::╔══╝   ╚::╗ ::╔╝     ::║   ::║
                ███████║██║     ███████╗███████╗ ::::::╔╝     ::║  ::║ :::::::╗  ╚::::╔╝      ╚::::::╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ ", @"
            
                ███████╗██████╗ ███████╗███████╗ ██████╗      ::::::╗  :::::::╗ ::╗   ::╗     ::╗   ::╗
                ██╔════╝██╔══██╗██╔════╝██╔════╝ ██╔══██╗     ::╔══::╗ ::╔════╝ ::║   ::║     ::║   ::║
                ███████╗██████╔╝█████╗  █████╗   ██║  ██║     ::::::╔╝ :::::╗   ::║   ::║     ::║   ::║
                ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ██║  ██║     ::╔══::╗ ::╔══╝   ╚::╗ ::╔╝     ::║   ::║
                ███████║██║     ███████╗███████╗ ██████╔╝     ::║  ::║ :::::::╗  ╚::::╔╝      ╚::::::╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ ", @"
            
                ███████╗██████╗ ███████╗███████╗ ██████╗      ██████╗  :::::::╗ ::╗   ::╗     ::╗   ::╗
                ██╔════╝██╔══██╗██╔════╝██╔════╝ ██╔══██╗     ██╔══██╗ ::╔════╝ ::║   ::║     ::║   ::║
                ███████╗██████╔╝█████╗  █████╗   ██║  ██║     ██████╔╝ :::::╗   ::║   ::║     ::║   ::║
                ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ██║  ██║     ██╔══██╗ ::╔══╝   ╚::╗ ::╔╝     ::║   ::║
                ███████║██║     ███████╗███████╗ ██████╔╝     ██║  ██║ :::::::╗  ╚::::╔╝      ╚::::::╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ ", @"
           
                ███████╗██████╗ ███████╗███████╗ ██████╗      ██████╗  ███████╗ ::╗   ::╗     ::╗   ::╗
                ██╔════╝██╔══██╗██╔════╝██╔════╝ ██╔══██╗     ██╔══██╗ ██╔════╝ ::║   ::║     ::║   ::║
                ███████╗██████╔╝█████╗  █████╗   ██║  ██║     ██████╔╝ █████╗   ::║   ::║     ::║   ::║
                ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ██║  ██║     ██╔══██╗ ██╔══╝   ╚::╗ ::╔╝     ::║   ::║
                ███████║██║     ███████╗███████╗ ██████╔╝     ██║  ██║ ███████╗  ╚::::╔╝      ╚::::::╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ ", @"
          
                ███████╗██████╗ ███████╗███████╗ ██████╗      ██████╗  ███████╗ ██╗   ██╗     ::╗   ::╗
                ██╔════╝██╔══██╗██╔════╝██╔════╝ ██╔══██╗     ██╔══██╗ ██╔════╝ ██║   ██║     ::║   ::║
                ███████╗██████╔╝█████╗  █████╗   ██║  ██║     ██████╔╝ █████╗   ██║   ██║     ::║   ::║
                ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ██║  ██║     ██╔══██╗ ██╔══╝   ╚██╗ ██╔╝     ::║   ::║
                ███████║██║     ███████╗███████╗ ██████╔╝     ██║  ██║ ███████╗  ╚████╔╝      ╚::::::╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ ", @"
            
                ███████╗██████╗ ███████╗███████╗ ██████╗      ██████╗  ███████╗ ██╗   ██╗     ██╗   ██╗
                ██╔════╝██╔══██╗██╔════╝██╔════╝ ██╔══██╗     ██╔══██╗ ██╔════╝ ██║   ██║     ██║   ██║
                ███████╗██████╔╝█████╗  █████╗   ██║  ██║     ██████╔╝ █████╗   ██║   ██║     ██║   ██║
                ╚════██║██╔═══╝ ██╔══╝  ██╔══╝   ██║  ██║     ██╔══██╗ ██╔══╝   ╚██╗ ██╔╝     ██║   ██║
                ███████║██║     ███████╗███████╗ ██████╔╝     ██║  ██║ ███████╗  ╚████╔╝      ╚██████╔╝
                ╚══════╝╚═╝     ╚══════╝╚══════╝ ╚═════╝      ╚═╝  ╚═╝ ╚══════╝   ╚═══╝        ╚═════╝ "

        };
            AnimateFrames(frames, 1, 600);            
            Console.ResetColor();


            string[] divider = { @"










                                                        ═══════════              
                                                                                 
                                                                                 ", @"










                                                ═════════════════════════════     
                                                                                 
                                                                                 ", @"










                                        ╔═══════════════════════════════════════╗
                                                                                 
                                                                                 ", @"










                                        ╔═══════════════════════════════════════╗
                                        ║         Press Enter to Start          ║
                                        ╚══                                   ══╝", @" 










                                        ╔═══════════════════════════════════════╗
                                        ║                                       ║
                                        ╚═════                             ═════╝", @" 










                                        ╔═══════════════════════════════════════╗
                                        ║         Press Enter to Start          ║
                                        ╚══════════════           ══════════════╝", @"










                                        ╔═══════════════════════════════════════╗
                                        ║                                       ║
                                        ╚═══════════════════════════════════════╝", @"










                                        ╔═══════════════════════════════════════╗
                                        ║         Press Enter to Start          ║
                                        ╚═══════════════════════════════════════╝





___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_____|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_____|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_____|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_____|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_____|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|_|___|___|___|___|___|___|___|___|___|___|___|___|"

        };
            AnimateFrames(divider, 3, 100);
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}