using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola worldcito!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine().Trim();

        if (name == null || name.Length == 0)
        {
            Console.WriteLine("Perrito escribe algo!");
            name = Console.ReadLine();

        }
        else
        {
            Console.WriteLine("Hola " + name);
        }

        string university = "BYUI";
        Console.WriteLine($"Yo estudio en {university}");

        
    }
}