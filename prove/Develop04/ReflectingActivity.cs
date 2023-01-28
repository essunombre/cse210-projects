public class ReflectingActivity : Activity
{
    private List<string> _reflectingPrompts = new List<string>();
    private List<string> _reflectingQuestions = new List<string>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 20)
    {


    }
    public void ReflectingExercise()
    {
        string ready = "";
        _reflectingPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectingPrompts.Add("Think of a time when you did something really difficult.");
        _reflectingPrompts.Add("Think of a time when you helped someone in need.");
        _reflectingPrompts.Add("Think of a time when you did something truly selfless.");

        int _questionsLength = _reflectingPrompts.Count - 1;
        Random R = new Random();
        int someRandomNumber = R.Next(0, _questionsLength);
        string finalRandomSelected = _reflectingPrompts.ElementAt(someRandomNumber);
        Console.WriteLine($"Consider the following prompt:\n --- {finalRandomSelected} ---\nWhen you have something in mind, press enter to continue.");
        ready = Console.ReadLine();
        if (ready != "")
        {
            Console.WriteLine($"\n\nConsider the following prompt:\n\n --- {finalRandomSelected} ---\n\nWhen you have something in mind, press enter to continue.");
        }
        else
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
            PausingCountdown(5);
            Console.Clear();
        }
    }

    public void QuestionsExercise()
    {
        _reflectingQuestions.Add("Why was this experience meaningful to you?");
        _reflectingQuestions.Add("Have you ever done anything like this before?");
        _reflectingQuestions.Add("How did you get started?");
        _reflectingQuestions.Add("How did you feel when it was complete?");
        _reflectingQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectingQuestions.Add("What is your favorite thing about this experience?");
        _reflectingQuestions.Add("How did you feel when it was complete?");
        _reflectingQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectingQuestions.Add("What did you learn about yourself through this experience?");
        _reflectingQuestions.Add("How can you keep this experience in mind in the future?");

        int duration = _durationSeconds;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            int _questionsLength = _reflectingQuestions.Count - 1;
            Random R = new Random();
            int someRandomNumber = R.Next(0, _questionsLength);
            string finalRandomSelected = _reflectingQuestions.ElementAt(someRandomNumber);
            Console.WriteLine(finalRandomSelected);
            ShowSpinner();
            ShowSpinner();
            ShowSpinner();
            currentTime = DateTime.Now;
        }

    }
}