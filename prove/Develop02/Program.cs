using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> _questions = new List<string>();
        _questions.Add("What was something you did good today?");
        _questions.Add("What made you laugh today?");
        _questions.Add("Who was an angel for you today?");
        _questions.Add("How did God talk to you today?");
        _questions.Add("What could have change your day?");

        bool stop = false;
        string writing = "";

        static void Write(List<String> _questions)
        {
            int _questionsLength = _questions.Count - 1;
            Random R = new Random();
            int someRandomNumber = R.Next(0, _questionsLength);
            Console.WriteLine(_questions.ElementAt(someRandomNumber));
        }

        static void Display()
        {
            string filename = "journal.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
                Console.WriteLine(line);
            }
        }

        static void Load(string filename)
        {
            string path = filename;
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
                Console.WriteLine(line);
            }
        }

        static void Save(string filename)
        {
            // using (StreamWriter outputFile = new StreamWriter(filename))
            using (StreamWriter sw = File.AppendText(filename))
            {
                // You can add text to the file with the WriteLine method
                sw.WriteLine("");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                sw.WriteLine($"My favorite color is {color}");
            }
        }
        

        while (!stop)
        {

            Console.WriteLine("Please select one fo the following choices:\n1. Write\n2. Display\n3. Load \n4. Save \n5. Quit\nWhat would you like to do?");
            string prompt = Console.ReadLine().Trim();
            int answer = int.Parse(prompt);
            //To write()
            if (answer == 1)
            {
                Write(_questions);
                writing = Console.ReadLine();

            }
            //To display()
            else if (answer == 2)
            {
                Console.WriteLine("You want to Display");
                Display();

            }
            //To load()
            else if (answer == 3)
            {
                Console.WriteLine("What is the file name?");
                string path = Console.ReadLine().Trim();
                Load(path);

            }
            //To save()
            else if (answer == 4)
            {
                Console.WriteLine("What is the file name?");
                string path = Console.ReadLine().Trim();
                Save(path);

            }
            //5 Quit
            else if (answer == 5)
            {
                stop = true;
                continue;
            }

        }

    }
}