using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        //Console.WriteLine("What is the magic number?");
        //string inputNumber = Console.ReadLine().Trim();
        //int magicNumber = int.Parse(inputNumber);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        Console.WriteLine($"Is {magicNumber}");
        int num = 0;
        do
        {
            Console.WriteLine("What is your guess");
            string inputGuess = Console.ReadLine().Trim();
            int guess = int.Parse(inputGuess);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                num = 1;
            }

        }while (num != 1);

    }
}