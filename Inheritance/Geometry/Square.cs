namespace Geometry;

public class Square : GeometricFigure
{
    private double _a;

    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    public double A { get => _a; set => _a = ValidateA(value); }

    public override double GetArea()
    {
        return Math.Pow(A, 2);
    }

    public override double GetPerimeter()
    {
        return 4*A;
    }

    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new ArgumentException("The sides must be greater than zero.");
        }
        return a;
    }
}