public class Swimming : Exercise
{
    private int _laps;
    public int GetLaps()
    {
        return _laps;
    }
    public Swimming(int laps, string date) : base(date)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) / 60;
    }
    public override double GetPace()
    {
        return GetMinutes()/GetDistance();
    }

    public override string GetSummary()
    {
        return $"Swimming ({GetMinutes()}): Distance {GetDistance()}km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}