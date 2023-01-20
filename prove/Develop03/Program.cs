using System;

class Program
{
    static void Main(string[] args)
    {
        var erase = true;

        Console.WriteLine("Hello Develop03 World!");
        Reference r = new Reference("1 Nephi", 3, 7);
        Console.WriteLine(r.GetReferenceString());
        Console.WriteLine();

        Scripture s = new Scripture(r, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Console.WriteLine(s.passageScripture());

        while (erase)
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            var answer = Console.ReadLine();
            if(answer != "quit")
            {
                Console.Clear();
                s.SetPassageComplete();
                erase = !s.SetPassageComplete();
                // Console.WriteLine(n);
                Console.WriteLine(s.passageScripture());
            }else{
                erase = false;
            }   
        }
    }
}