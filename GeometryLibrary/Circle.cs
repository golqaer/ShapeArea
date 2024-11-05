namespace GeometryLibrary;

public class Circle(double radius) : IShape
{
    public double Radius { get; } = radius;

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}