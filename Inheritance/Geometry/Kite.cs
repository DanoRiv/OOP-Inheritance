
namespace Geometry;

public class Kite : Rhombus
{
    private double _b;
    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        B = b;
    }

    public double B { get => _b; set => _b = ValidateB(value); }

    public override double GetArea()
    {
        return base.GetArea();
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