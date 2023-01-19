using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal j = new Journal();
        bool stop = false;

        while (!stop)
        {
            Console.WriteLine("Please select one fo the following choices:\n1. Write\n2. Display\n3. Load \n4. Save \n5. Quit\nWhat would you like to do?");
            string prompt = Console.ReadLine().Trim();
            int answer = int.Parse(prompt);
            //To write()
            if (answer == 1)
            {
                j.Write();

            }
            //To display()
            else if (answer == 2)
            {
                j.Display();
            }
            //To load()
            else if (answer == 3)
            {
                Console.WriteLine("What is the file name?");
                j.Load();
            }
            // //To save()
            else if (answer == 4)
            {
                Console.WriteLine("What is the file name?");
                j.Save();

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