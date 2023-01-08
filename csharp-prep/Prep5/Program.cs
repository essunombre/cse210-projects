using System;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine().Trim();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            string inputNumber = Console.ReadLine().Trim();
            int number = int.Parse(inputNumber);
            return number;
        }
        static int SquaredNumber(int number)
        {
            int result = number * number;
            return result;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {number}");

        }

        DisplayWelcome();
        string promptName = PromptUserName();
        int promptNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(promptNumber);
        DisplayResult(promptName, squaredNumber);

    }
}