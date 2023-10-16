using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Ellipse : IGeometry
{
    // Class fields.
    private double _majorAxis;
    private double _minorAxis;

    /*
     * Class properties.
     *
     * An Exception will be thrown if a developer attempts to assign a non-positive value to _majorAxis.
     * A comparison of the two axes is performed to ensure that the values aren't equal, since it's not an
     * ellipse if they are, but rather a circle. If they are equal, an exception is thrown, informing the developer
     * that they're not using the appropriate class.
     *
     * The same is logic is applied in the setter of MinorAxis, except it's vice versa.
     */
    public double MajorAxis
    {
        get => _majorAxis;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to _majorAxis");
            if (Math.Abs(value - _minorAxis) < 1E-12)
                throw new Exception("Attempted to assign the same value as _minorAxis to _majorAxis. If " +
                                    "this was intentional, use the Circle class instead.");
            _majorAxis = value;
        }
    }

    public double MinorAxis
    {
        get => _minorAxis;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to _minorAxis");
            if (Math.Abs(value - _majorAxis) < 1E-12)
                throw new Exception("Attempted to assign the same value as _majorAxis to _minorAxis. If " +
                                    "this was intentional, use the Circle class instead.");
            _minorAxis = value;
        }
    }
    
    public string Name => "Ellipse";
    public double Area => Math.PI * MajorAxis * MinorAxis;

    // Constructor with default values.
    public Ellipse(double majorAxis = 10, double minorAxis = 4)
    {
        MajorAxis = majorAxis;
        MinorAxis = minorAxis;
    }
}