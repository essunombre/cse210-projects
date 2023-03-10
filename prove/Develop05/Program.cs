using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        int choice;
        bool stop = false;

        List<Goal> goals = new List<Goal>();

        while (!stop)
        {
            Goal goal = new Goal();
            choice = goal.DisplayStartMessage();

            if (choice == 1)
            {
                choice = goal.DisplayOptions();

                if (choice == 1)
                {
                    Goal simpleGoal = new SimpleGoal();
                    simpleGoal.DisplayGoalInfo();
                }
                else if (choice == 2)
                {
                    Goal eternalGoal = new EternalGoal();
                    eternalGoal.DisplayGoalInfo();
                }
                else if (choice == 3)
                {
                    Goal checklistGoal = new ChecklistGoal();
                    checklistGoal.DisplayGoalInfo();
                }

            }
            else if(choice == 2)
            {
                goal.ListGoals();
            }
            else
            {
                Console.Clear();
                stop = true;
            }
        }
    }
}