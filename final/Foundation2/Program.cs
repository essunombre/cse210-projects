using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Address address1 = new Address();
        address1.SetCity("Salt Lake City");
        address1.SetStreet("20 N street");
        address1.SetCountry("United States");
        address1.SetState("Utah");
        address1.Display();
    }
}