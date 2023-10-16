using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Triangle : IGeometry
{
    private double _width;
    private double _height;

    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0) throw new Exception("Attempted to assign non-positive value to _width");
            _width = value;
        }
    }

    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0) throw new Exception("Attempted to assign non-positive value to _height");
            _height = value;
        }
    }

    public string Name => "Triangle";
    public double Area => Width * Height / 2;

    // Constructor with default values.
    public Triangle(double width = 2, double height = 6)
    {
        Width = width;
        Height = height;
    }
}