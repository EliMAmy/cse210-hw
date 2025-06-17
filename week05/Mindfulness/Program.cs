using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
        int enter = 0;
        while (enter == 0)
        {
            Console.WriteLine("\nMenu Options");
            Console.WriteLine("1. Start breathing acivity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            int chose = int.Parse(choice);
            Console.Clear();

            if (chose == 1)
            {
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int duration = 0;

                BreathingActivity activity = new BreathingActivity(name, description, duration);
                activity.DisplayStartingMessage();
                Console.Clear();
                activity.ShowSpinner();
                activity.Run();
                activity.DisplayEndingMessage();
                
            }
            else if (chose == 2)
            {
                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                int duration = 0;

                ReflectionActivity activity2 = new ReflectionActivity(name, description, duration);
                activity2.DisplayStartingMessage();
                Console.Clear();
                activity2.ShowSpinner();
                Console.WriteLine("Consider the following prompt:\n");
                Console.WriteLine($"---{activity2.GetRandomPrompt()}---");
                Console.WriteLine("\nWhen you have something in mind, press enter to continue.\n");
                string enterClick = Console.ReadLine();
                if (enterClick == "")
                {
                    activity2.Run();
                }
                activity2.DisplayEndingMessage();
            }
            else if (chose == 3)
            {
                string name = "Listing Activity";
                string description = "his activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                int duration = 0;
                int count = 0;
                string prompt1 = "Who are people that you appreciate?";
                string prompt2 = "What are personal strengths of yours?";
                string prompt3 = "Who are people that you have helped this week?";
                string prompt4 = "When have you felt the Holy Ghost this month?";
                string prompt5 = "Who are some of your personal heroes?";

                ListingActivity activity3 = new ListingActivity(name, description, duration, count);
                activity3.SetPrompt(prompt1);
                activity3.SetPrompt(prompt2);
                activity3.SetPrompt(prompt3);
                activity3.SetPrompt(prompt4);
                activity3.SetPrompt(prompt5);

                activity3.DisplayStartingMessage();
                Console.Clear();
                activity3.ShowSpinner();
                Console.WriteLine("List as many responses you can to the following prompt:");
                Console.WriteLine($"---{activity3.GetRandomPrompt()}---");
                activity3.Run();
                activity3.DisplayEndingMessage();
            }
            else
            {
                enter = 1;
            }

        }
    }
}