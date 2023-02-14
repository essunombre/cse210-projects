using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Swimming swim1 = new Swimming(50, "June 9th");
        Running run1 = new Running(100, "Septemeber 9th");
        Cycling cyc1 = new Cycling(30, "Febrary 31th");

        List<Exercise> exercises = new List<Exercise>();
        exercises.Add(swim1);
        exercises.Add(run1);
        exercises.Add(cyc1);

        foreach(Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
            Console.WriteLine("");
        }

    }
}