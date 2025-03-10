﻿namespace Geometry;

public class Parallelogram : Rectangle
{
    private double _h;

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    public double H { get => _h; set => _h = ValidateH(value); }

    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return base.GetPerimeter();
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The height must be greater than zero.");
        }
        return h;
    }
}