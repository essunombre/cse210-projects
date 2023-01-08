using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Insert final grade:");
        string grade = Console.ReadLine().Trim();
        int number = int.Parse(grade);
        string final = "";

        if (number >= 90){
            final = "A";
        }
        else if (number >= 80 ){
            final = "B";
        }
        else if (number >= 70){
            final = "C";
        }
        else if (number >= 60){
            final = "D";
        }
        else if (number < 60){
            final = "F";
        }

        Console.WriteLine($"Final Grade: {final}.");

    }
}