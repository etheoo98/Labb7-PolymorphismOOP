using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Triangle : IGeometry
{
    public string Name => "Triangle";
    public double Area => Width * Height / 2;
    
    /*
     * We check the value of width sent to the constructor, to ensure that it is a positive value, since widths aren't
     * expected to be negative or zero, before we assign the value to the _width field. If it is not a positive value an
     * exception is thrown.
     *
     * The same is logic is applied in the setter of Height.
     */
    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0) throw new Exception("Attempted to assign non-positive value to '_width'");
            _width = value;
        }
    }
    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0) throw new Exception("Attempted to assign non-positive value to '_height'");
            _height = value;
        }
    }
    
    public Triangle(double width = 2, double height = 6)
    {
        Width = width;
        Height = height;
    }
    
    private double _width;
    private double _height;
}