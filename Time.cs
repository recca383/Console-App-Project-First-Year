﻿using System;
using System.Timers;
using System.Threading;

class Time
{
    private static int countdown = 30;
    private static System.Timers.Timer timer;

   public static void Timers()
    {
        timer = new System.Timers.Timer(1000);
        timer.Elapsed += OnTimedEvent;
        timer.Enabled = true;  // Start the timer

        Console.WriteLine("Welcome! You have 30 seconds.");

        Thread.Sleep(30000);

        Console.WriteLine("Time's up!");
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        countdown--;  // Decrement the countdown

        // Display the remaining time
        Console.Clear();
        Console.WriteLine($"Time left: {countdown} seconds");

        // If the countdown reaches 0, stop and dispose of the timer
        if (countdown == 0)
        {
            timer.Stop();
            timer.Dispose();
        }
    }
}
