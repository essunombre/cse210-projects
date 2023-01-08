using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool stop = false;
        while (!stop)
        {
            Console.WriteLine("Enter a number: ");
            string inputNumber = Console.ReadLine().Trim();
            int number = int.Parse(inputNumber);
            if (number == 0)
            { 
                stop = true;
                continue; 
            }
            numbers.Add(number);
        }
        Console.WriteLine("The sum is: " + numbers.Sum());
        Console.WriteLine("The average is: " + numbers.Average());
        Console.WriteLine("The largest number is: " + numbers.Max());
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

    }
}