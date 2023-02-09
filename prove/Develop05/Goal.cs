public class Goal
{
    private string _goalName = "";
    private string _goalDescription = "";
    private int _goalPoints;
    public bool _goalFinished;
    public int _choice;

    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }
    public int GetGoalPoints()
    {
        return _goalPoints;
    }
    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }
    public int DisplayStartMessage()
    {
        // return "You have 0 points.\n\nMenu Options:\n\t1. Create a new Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\nSelect a choice from the menu:";
        Console.WriteLine("You have 0 points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create a new Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.WriteLine($"Select a choice from the menu:");
        return Convert.ToInt32(Console.ReadLine());
    }
    public int DisplayOptions()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        return Convert.ToInt32(Console.ReadLine());
    }
    public virtual void DisplayGoalInfo()
    {
        Console.WriteLine("What is the name of your goal?");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is a short description of it?");
        SetGoalDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");  
        SetGoalPoints(Convert.ToInt32(Console.ReadLine()));
    }
    public void ListGoals()
    {
       Console.WriteLine("The goals are");
       Console.WriteLine($"{GetGoalName()} ({GetGoalDescription()})");

    }



    // public abstract void RecordEvent();
    // public abstract void IsComplete();

}