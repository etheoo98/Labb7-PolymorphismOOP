using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Rectangle : IGeometry
{
    public virtual string Name => "Rectangle";
    public double Area => Width * Height;
    /*
     * We check the value of width sent to the constructor, to ensure that it is a positive value, since widths aren't,
     * expected to be negative or zero, before we assign the value to the _width field. If it is not a positive value
     * an exception is thrown.
     *
     * A comparison of the two axes is also performed to ensure that the values aren't considered equal, since it's not
     * a rectangle if they are, but rather a square or rhombus. If they are considered equal, an exception is thrown.
     *
     * The same is logic is applied in the setter of Height, except it's vice versa.
     */
    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to '_width'.");
            if (Math.Abs(value - Height) < 1E-12)
                throw new Exception("Attempted to assign the same value as '_height' to '_width'. If this was " +
                                    "intentional, use the 'Square' or 'Rhombus' class instead.");
            _width = value;
        }
    }
    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to '_height'.");
            if (Math.Abs(value - Width) < 1E-12)
                throw new Exception("Attempted to assign the same value as '_width' to '_height'. If this was " +
                                    "intentional, use the 'Square' or 'Rhombus' class instead.");
            _height = value;
        }
    }
    
    public Rectangle(double width = 9.01, double height = 2)
    {
        Width = width;
        Height = height;
    }
    
    private double _width;
    private double _height;
}