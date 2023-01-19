public class Fraction
{
    //private attributes
    private int _top;
    private int _bottom;
    
    //Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    //Constructor that has one parameter for the top and that initializes the denominator to 1. 
    //So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    // Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    // Create getters and setters for both the top and the bottom values.
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString =  $"{_top}/{_bottom}"; 
        return fractionString;
    } 
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }
}