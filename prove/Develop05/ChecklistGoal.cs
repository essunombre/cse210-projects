public class ChecklistGoal : Goal
{
    private int _goalTimes;
    private int _goalBonus;
    public int GetGoalTImes()
    {
        return _goalTimes;
    }
    public void SetGoalTimes(int goalTimes)
    {
        _goalTimes = goalTimes;
    }
    public int GetGoalBonus()
    {
        return _goalBonus;
    }
    public void SetGoalBonus(int goalBonus)
    {
        _goalBonus = goalBonus;
    }
    public override void DisplayGoalInfo()
    {
        Console.WriteLine("What is the name of your goal?");
        SetGoalName(Console.ReadLine());
        Console.WriteLine("What is a short description of it?");
        SetGoalDescription(Console.ReadLine());
        Console.WriteLine("What is the amount of points associated with this goal?");  
        SetGoalPoints(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");  
        SetGoalTimes(Convert.ToInt32(Console.ReadLine()));          
        Console.WriteLine("What is the bonus for accomplishing it that many times?");  
        SetGoalBonus(Convert.ToInt32(Console.ReadLine()));          
    }
        
}