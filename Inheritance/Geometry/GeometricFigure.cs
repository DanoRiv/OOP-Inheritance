namespace Geometry;

public abstract class GeometricFigure
{
    public string Name { get; set; } = string.Empty;

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),15:N5} \tPerimeter: {GetPerimeter(),15:N5}";
    }
}

