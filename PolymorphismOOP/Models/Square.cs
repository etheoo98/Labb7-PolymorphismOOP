using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Square : IGeometry
{
    // Class field.
    private double _side;

    /*
     * Class Property.
     *
     * An exception will be thrown if a developer attempts to assign a non-positive value to _side.
     */
    public double Side
    {
        get => _side;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to _side");
            _side = value;
        }
    }

    // Virtual properties that should be overridden by class inheritors.
    public virtual string Name => "Square";
    public virtual double Area => Math.Pow(Side, 2);

    // Constructor with a default value.
    public Square(double side = 6)
    {
        Side = side;
    }
}