using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        // Console.WriteLine($"{_company}, {_jobTitle}, {_startYear}, {_endYear}");
        job1._company = "Selazar";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2022;
        job1._endYear = 2023;
        
        Job job2 = new Job();
        job2._company = "Sura";
        job2._jobTitle = "Application Annalyst";
        job2._startYear = 2018;
        job2._endYear = 2021;

        // job1.Display();

        Resume myResume = new Resume();
        myResume._jobs = new List<Job>(){job1, job2};
        myResume._name = "Allison Rose";

        myResume.Display();


    }
}