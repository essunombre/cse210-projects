public class Running : Exercise
{
    private int _distance;

    public Running(int distance, string date) : base(date)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return ((GetDistance()) / GetMinutes()) / 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"Running ({GetMinutes()}): Distance {GetDistance()}km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}