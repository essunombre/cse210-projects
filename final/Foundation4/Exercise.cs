public abstract class Exercise
{
    private string _date = "";
    private int _minutes;
    private int _distance;
    private int _speed;
    private int _pace;
    public Exercise(string date)
    {
        _date = date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public abstract double GetDistance(); 
    public abstract double GetSpeed(); 
    public abstract double GetPace(); 

    public abstract string GetSummary();
}