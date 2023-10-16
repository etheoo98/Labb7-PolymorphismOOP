using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Rectangle : IGeometry
{
    // Class fields.
    private double _width;
    private double _height;

    /*
     * Class properties.
     *
     * An Exception will be thrown if a developer attempts to assign a non-positive value to _width.
     * A comparison of the two sides is performed to ensure that the values aren't equal, since it's not a
     * rectangle if they are, but rather a square. If they are equal, an exception is thrown, informing the developer
     * that they're not using the appropriate class.
     *
     * The same is logic is applied in the setter of Height, except it's vice versa.
     */
    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to _width.");
            if (Math.Abs(value - Height) < 1E-12)
                throw new Exception("Attempted to assign the same value as _height to width. If this was " +
                                    "intentional, use the Square or Rhombus class instead.");
            _width = value;
        }
    }

    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to _height.");
            if (Math.Abs(value - Width) < 1E-12)
                throw new Exception("Attempted to assign the same value as _width to _height. If this was " +
                                    "intentional, use the Square or Rhombus class instead.");
            _height = value;
        }
    }

    public virtual string Name => "Rectangle";
    public double Area => Width * Height;

    // Constructor with default values.
    public Rectangle(double width = 9.01, double height = 2)
    {
        Width = width;
        Height = height;
    }
}