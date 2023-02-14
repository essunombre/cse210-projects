public class Cycling : Exercise
{
    private int _speed;
    public override double GetSpeed()
    {
        return _speed;
    }

    public Cycling(int speed, string date) : base(date)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed * 60) / GetMinutes();
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
    public override string GetSummary()
    {
        return $"Cycling ({GetMinutes()}): Distance {GetDistance()}km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}