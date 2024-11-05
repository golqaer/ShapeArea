namespace GeometryLibrary;

public class Triangle(double a, double b, double c) : IShape
{
    public double A { get; } = a;
    public double B { get; } = b;
    public double C { get; } = c;

    public double GetArea()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    public bool IsRightTriangle()
    {
        return Math.Abs(A * A + B * B - C * C) < 1e-10 ||
               Math.Abs(A * A + C * C - B * B) < 1e-10 ||
               Math.Abs(B * B + C * C - A * A) < 1e-10;
    }
}