namespace Geometry;

public class Rectangle : Square
{
  
    private double _b;

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    public double B { get => _b; set => _b = ValidateB(value); }

    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("The side must be greater than zero.");
        }
        return b;
    }
}