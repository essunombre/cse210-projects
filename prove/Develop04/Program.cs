using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        int seconds;
        bool stop = false;

        while (!stop)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start Breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.WriteLine($"Select a choice from the menu:");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity bActivity = new BreathingActivity();
                Console.WriteLine(bActivity.DisplayStartMessage());
                seconds = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                bActivity.SetTime(seconds);
                Console.Clear();
                Console.WriteLine("Get ready...");
                bActivity.ShowSpinner();
                bActivity.BreathingExercise();
                Console.WriteLine("Well done!");
                bActivity.ShowSpinner();
                bActivity.DisplayEndMessage();
                bActivity.ShowSpinner();;
                Console.Clear();
            }
            else if (choice == 2)
            {
                Console.Clear();
                ReflectingActivity rActivity = new ReflectingActivity();
                Console.WriteLine(rActivity.DisplayStartMessage());
                seconds = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                rActivity.SetTime(seconds);
                Console.Clear();
                Console.WriteLine("Get ready...");
                rActivity.ShowSpinner();
                rActivity.ReflectingExercise();
                rActivity.QuestionsExercise();
                Console.WriteLine("Well done!");
                rActivity.ShowSpinner();
                rActivity.DisplayEndMessage();
                rActivity.ShowSpinner();
                Console.Clear();

            }
            else if (choice == 3)
            {
                Console.Clear();
                ListingActivity lActivity = new ListingActivity();
                Console.WriteLine(lActivity.DisplayStartMessage());
                seconds = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                lActivity.SetTime(seconds);
                Console.Clear();
                Console.WriteLine("Get ready...");
                lActivity.ShowSpinner();
                lActivity.ListingExercise();
                Console.WriteLine("Well done!");
                lActivity.DisplayEndMessage();
                lActivity.ShowSpinner();
                lActivity.ShowSpinner();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                stop = true;
            }
        }
    }
}