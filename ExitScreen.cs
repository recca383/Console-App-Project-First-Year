﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Project_First_Year
{
    internal class ExitScreen
    {
        public static void ThankYou()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorVisible = false;
            string[] thankyou = { @"
 

                        ::::::::╗::╗  ::╗ :::::╗ :::╗   ::╗::╗  ::╗    ::╗   ::╗ ::::::╗ ::╗   ::╗
                        ╚══::╔══╝::║  ::║::╔══::╗::::╗  ::║::║ ::╔╝    ╚::╗ ::╔╝::╔═══::╗::║   ::║
                           ::║   :::::::║:::::::║::╔::╗ ::║:::::╔╝      ╚::::╔╝ ::║   ::║::║   ::║
                           ::║   ::╔══::║::╔══::║::║╚::╗::║::╔═::╗       ╚::╔╝  ::║   ::║::║   ::║
                           ::║   ::║  ::║::║  ::║::║ ╚::::║::║  ::╗       ::║   ╚::::::╔╝╚::::::╔╝
                           ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝       ╚═╝    ╚═════╝  ╚═════╝                                                                                                                                                                                                                                                    
                :::::::╗ ::::::╗ ::::::╗     ::::::╗ :::::::╗::╗   ::╗::╗:::::::╗::╗    ::╗::╗:::╗   ::╗ ::::::╗ 
                ::╔════╝::╔═══::╗::╔══::╗    ::╔══::╗::╔════╝::║   ::║::║::╔════╝::║    ::║::║::::╗  ::║::╔════╝ 
                :::::╗  ::║   ::║::::::╔╝    ::::::╔╝:::::╗  ::║   ::║::║:::::╗  ::║ :╗ ::║::║::╔::╗ ::║::║  :::╗
                ::╔══╝  ::║   ::║::╔══::╗    ::╔══::╗::╔══╝  ╚::╗ ::╔╝::║::╔══╝  ::║:::╗::║::║::║╚::╗::║::║   ::║
                ::║     ╚::::::╔╝::║  ::║    ::║  ::║:::::::╗ ╚::::╔╝ ::║:::::::╗╚:::╔:::╔╝::║::║ ╚::::║╚::::::╔╝
                ╚═╝      ╚═════╝ ╚═╝  ╚═╝    ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚═╝╚══════╝ ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                                 
                                     ::╗    ::╗::╗::::::::╗::╗  ::╗    ::╗   ::╗:::::::╗
                                     ::║    ::║::║╚══::╔══╝::║  ::║    ::║   ::║::╔════╝
                                     ::║ :╗ ::║::║   ::║   :::::::║    ::║   ::║:::::::╗
                                     ::║:::╗::║::║   ::║   ::╔══::║    ::║   ::║╚════::║
                                     ╚:::╔:::╔╝::║   ::║   ::║  ::║    ╚::::::╔╝:::::::║
                                      ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝     ╚═════╝ ╚══════╝                          ", @"
 

                        ████████╗██╗  ██╗ █████╗ ███╗   ██╗██╗  ██╗    ██╗   ██╗ ██████╗ ██╗   ██╗
                        ╚══██╔══╝██║  ██║██╔══██╗████╗  ██║██║ ██╔╝    ╚██╗ ██╔╝██╔═══██╗██║   ██║
                           ██║   ███████║███████║██╔██╗ ██║█████╔╝      ╚████╔╝ ██║   ██║██║   ██║
                           ██║   ██╔══██║██╔══██║██║╚██╗██║██╔═██╗       ╚██╔╝  ██║   ██║██║   ██║
                           ██║   ██║  ██║██║  ██║██║ ╚████║██║  ██╗       ██║   ╚██████╔╝╚██████╔╝
                           ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝       ╚═╝    ╚═════╝  ╚═════╝ 
                                                                                                                                                                          
                :::::::╗ ::::::╗ ::::::╗     ::::::╗ :::::::╗::╗   ::╗::╗:::::::╗::╗    ::╗::╗:::╗   ::╗ ::::::╗ 
                ::╔════╝::╔═══::╗::╔══::╗    ::╔══::╗::╔════╝::║   ::║::║::╔════╝::║    ::║::║::::╗  ::║::╔════╝ 
                :::::╗  ::║   ::║::::::╔╝    ::::::╔╝:::::╗  ::║   ::║::║:::::╗  ::║ :╗ ::║::║::╔::╗ ::║::║  :::╗
                ::╔══╝  ::║   ::║::╔══::╗    ::╔══::╗::╔══╝  ╚::╗ ::╔╝::║::╔══╝  ::║:::╗::║::║::║╚::╗::║::║   ::║
                ::║     ╚::::::╔╝::║  ::║    ::║  ::║:::::::╗ ╚::::╔╝ ::║:::::::╗╚:::╔:::╔╝::║::║ ╚::::║╚::::::╔╝
                ╚═╝      ╚═════╝ ╚═╝  ╚═╝    ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚═╝╚══════╝ ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                                 
                                     ::╗    ::╗::╗::::::::╗::╗  ::╗    ::╗   ::╗:::::::╗
                                     ::║    ::║::║╚══::╔══╝::║  ::║    ::║   ::║::╔════╝
                                     ::║ :╗ ::║::║   ::║   :::::::║    ::║   ::║:::::::╗
                                     ::║:::╗::║::║   ::║   ::╔══::║    ::║   ::║╚════::║
                                     ╚:::╔:::╔╝::║   ::║   ::║  ::║    ╚::::::╔╝:::::::║
                                      ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝     ╚═════╝ ╚══════╝                          ", @"

 
                        ████████╗██╗  ██╗ █████╗ ███╗   ██╗██╗  ██╗    ██╗   ██╗ ██████╗ ██╗   ██╗
                        ╚══██╔══╝██║  ██║██╔══██╗████╗  ██║██║ ██╔╝    ╚██╗ ██╔╝██╔═══██╗██║   ██║
                           ██║   ███████║███████║██╔██╗ ██║█████╔╝      ╚████╔╝ ██║   ██║██║   ██║
                           ██║   ██╔══██║██╔══██║██║╚██╗██║██╔═██╗       ╚██╔╝  ██║   ██║██║   ██║
                           ██║   ██║  ██║██║  ██║██║ ╚████║██║  ██╗       ██║   ╚██████╔╝╚██████╔╝
                           ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝       ╚═╝    ╚═════╝  ╚═════╝ 
                                                                                                                                                                           
                ███████╗ ██████╗ ██████╗     ██████╗ ███████╗██╗   ██╗██╗███████╗██╗    ██╗██╗███╗   ██╗ ██████╗ 
                ██╔════╝██╔═══██╗██╔══██╗    ██╔══██╗██╔════╝██║   ██║██║██╔════╝██║    ██║██║████╗  ██║██╔════╝ 
                █████╗  ██║   ██║██████╔╝    ██████╔╝█████╗  ██║   ██║██║█████╗  ██║ █╗ ██║██║██╔██╗ ██║██║  ███╗
                ██╔══╝  ██║   ██║██╔══██╗    ██╔══██╗██╔══╝  ╚██╗ ██╔╝██║██╔══╝  ██║███╗██║██║██║╚██╗██║██║   ██║
                ██║     ╚██████╔╝██║  ██║    ██║  ██║███████╗ ╚████╔╝ ██║███████╗╚███╔███╔╝██║██║ ╚████║╚██████╔╝
                ╚═╝      ╚═════╝ ╚═╝  ╚═╝    ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚═╝╚══════╝ ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                                
                                     ::╗    ::╗::╗::::::::╗::╗  ::╗    ::╗   ::╗:::::::╗
                                     ::║    ::║::║╚══::╔══╝::║  ::║    ::║   ::║::╔════╝
                                     ::║ :╗ ::║::║   ::║   :::::::║    ::║   ::║:::::::╗
                                     ::║:::╗::║::║   ::║   ::╔══::║    ::║   ::║╚════::║
                                     ╚:::╔:::╔╝::║   ::║   ::║  ::║    ╚::::::╔╝:::::::║
                                      ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝     ╚═════╝ ╚══════╝                          ", @"


                        ████████╗██╗  ██╗ █████╗ ███╗   ██╗██╗  ██╗    ██╗   ██╗ ██████╗ ██╗   ██╗
                        ╚══██╔══╝██║  ██║██╔══██╗████╗  ██║██║ ██╔╝    ╚██╗ ██╔╝██╔═══██╗██║   ██║
                           ██║   ███████║███████║██╔██╗ ██║█████╔╝      ╚████╔╝ ██║   ██║██║   ██║
                           ██║   ██╔══██║██╔══██║██║╚██╗██║██╔═██╗       ╚██╔╝  ██║   ██║██║   ██║
                           ██║   ██║  ██║██║  ██║██║ ╚████║██║  ██╗       ██║   ╚██████╔╝╚██████╔╝
                           ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝       ╚═╝    ╚═════╝  ╚═════╝ 
                                                                                                                                                                          
                ███████╗ ██████╗ ██████╗     ██████╗ ███████╗██╗   ██╗██╗███████╗██╗    ██╗██╗███╗   ██╗ ██████╗ 
                ██╔════╝██╔═══██╗██╔══██╗    ██╔══██╗██╔════╝██║   ██║██║██╔════╝██║    ██║██║████╗  ██║██╔════╝ 
                █████╗  ██║   ██║██████╔╝    ██████╔╝█████╗  ██║   ██║██║█████╗  ██║ █╗ ██║██║██╔██╗ ██║██║  ███╗
                ██╔══╝  ██║   ██║██╔══██╗    ██╔══██╗██╔══╝  ╚██╗ ██╔╝██║██╔══╝  ██║███╗██║██║██║╚██╗██║██║   ██║
                ██║     ╚██████╔╝██║  ██║    ██║  ██║███████╗ ╚████╔╝ ██║███████╗╚███╔███╔╝██║██║ ╚████║╚██████╔╝
                ╚═╝      ╚═════╝ ╚═╝  ╚═╝    ╚═╝  ╚═╝╚══════╝  ╚═══╝  ╚═╝╚══════╝ ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                                 
                                     ██╗    ██╗██╗████████╗██╗  ██╗    ██╗   ██╗███████╗
                                     ██║    ██║██║╚══██╔══╝██║  ██║    ██║   ██║██╔════╝
                                     ██║ █╗ ██║██║   ██║   ███████║    ██║   ██║███████╗
                                     ██║███╗██║██║   ██║   ██╔══██║    ██║   ██║╚════██║
                                     ╚███╔███╔╝██║   ██║   ██║  ██║    ╚██████╔╝███████║
                                      ╚══╝╚══╝ ╚═╝   ╚═╝   ╚═╝  ╚═╝     ╚═════╝ ╚══════╝                           "
        };
            LoadingScreen.AnimateFrames(thankyou, 3, 100);
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }
}
