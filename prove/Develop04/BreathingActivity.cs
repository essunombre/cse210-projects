public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly clear your mind and focus on your breathing", 10)
    {

    }
    public void BreathingExercise()
    {
        int duration = _durationSeconds;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine($"Breath in...");
            PausingCountdown(4);
            Console.WriteLine($"Now breath out...");
            PausingCountdown(6);
            Console.WriteLine("");
            currentTime = DateTime.Now;
            
        }

    }



}