public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>();
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you a list as many things as you can in a certain area", 30)
    {

    }
    public void ListingExercise()
    {
        string reflection = "";
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heroes?");

        int _questionsLength = _listingPrompts.Count - 1;
        Random R = new Random();
        int someRandomNumber = R.Next(0, _questionsLength);
        string finalRandomSelected = _listingPrompts.ElementAt(someRandomNumber);
        Console.WriteLine($"List as many responses you can to the following prompt:\n --- {finalRandomSelected} --- \nYou may begin in:");
        PausingCountdown(5);

        int duration = _durationSeconds;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        List<string> _reflections = new List<string>();
        while (currentTime < futureTime)
        {
            reflection = Console.ReadLine();
            _reflections.Add(reflection);
            currentTime = DateTime.Now;
        }
        int reflectionsLenght = _reflections.Count;
        Console.WriteLine($"You listed {reflectionsLenght} items!");
    }
}
