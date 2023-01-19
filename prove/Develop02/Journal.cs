public class Journal
{
    List<string> _questions = new List<string>();
    string journalEntry;
    string path;
    string fileName;
    public Journal()
    {
        _questions.Add("What was something you did good today?");
        _questions.Add("What made you laugh today?");
        _questions.Add("Who was an angel for you today?");
        _questions.Add("How did God talk to you today?");
        _questions.Add("What could have change your day?");

    }

    public void Write()
    {
        int _questionsLength = _questions.Count - 1;
        Random R = new Random();
        int someRandomNumber = R.Next(0, _questionsLength);
        Console.WriteLine(_questions.ElementAt(someRandomNumber));
        var answer = Console.ReadLine();
        DateTime today = DateTime.Now;
        journalEntry += $"Date: {today.ToString("dd/MM/yyyy")} - Prompt: {_questions.ElementAt(someRandomNumber)}\n{answer}\n\n";


    }

    public void Display()
    {
        Console.WriteLine(journalEntry);
    }
    public void Load()
    {

        path = Console.ReadLine().Trim();
        string[] lines = System.IO.File.ReadAllLines(path);

        foreach (string line in lines)
        {
            string[] parts = line.Split("");
            Console.WriteLine(line);
        }
    }
    public void Save()
    {
        fileName = Console.ReadLine().Trim();
        // using (StreamWriter outputFile = new StreamWriter(filename))
        using (StreamWriter sw = File.AppendText(fileName))
        {
            sw.WriteLine($"{journalEntry}");
        }
    }
}