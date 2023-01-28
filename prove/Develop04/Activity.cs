public class Activity
{
    private string _activityName = "";
    private string _description = "";
    protected int _durationSeconds = 0;

    public Activity()
    {

    }

    public Activity(string activityName, string description, int durationSeconds)
    {
        _activityName = activityName;
        _description = description;
        _durationSeconds = durationSeconds;

    }
    public int GetTime()
    {
        return _durationSeconds;
    }
    public void SetTime(int durationSeconds)
    {
        _durationSeconds = durationSeconds;
    }

    public string DisplayStartMessage()
    {
        return $"Welcome to the {_activityName}.\n\n{_description}.\n\nHow long, in seconds, would you like for your session?";
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName}.");
    }
    public void ShowSpinner()
    {
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        // Console.WriteLine("|");
    }
    public void PausingCountdown(int timer)
    {
        int counter = timer;
        while (counter != 0)
        {
            Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            counter -= 1;
            timer -= 1;
        }


    }

    public void PausingWhileShowingSpinner()
    {
        bool direction = true; //True Up, False Down
        int animation = 1;
        decimal seconds = _durationSeconds * 1000;
        while (seconds > 0)
        {
            Console.Clear();
            if (animation == 1)
            {
                Console.WriteLine("  .  ");
            }
            else if (animation == 2)
            {
                Console.WriteLine(" ... ");
            }
            else if (animation == 3)
            {
                Console.WriteLine(".....");
            }

            if (animation == 3)
            {
                animation -= 1;
                direction = false;
            }
            else if (animation == 2 && !direction)
            {
                animation -= 1;
            }
            else if (animation == 2 && direction)
            {
                animation += 1;
            }
            else if (animation == 1)
            {
                animation += 1;
                direction = true;
            }

            Thread.Sleep(500);
            seconds -= 500;

        }
    }
    public void TestFor()
    {
        {

            decimal seconds = _durationSeconds * 1000;
            while (seconds > 0)
            {
                Console.Clear();


                Thread.Sleep(500);
                seconds -= 500;
            }
        }
    }
}