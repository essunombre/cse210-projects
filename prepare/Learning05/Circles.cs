public class Circles : Shape
{
    public double _radius;

    public Circles(double radius, string color) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }
}