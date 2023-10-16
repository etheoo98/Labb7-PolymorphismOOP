using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Circle : IGeometry
{
    // Class field.
    private double _radius;
    
    // Class Property.
    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to _radius");
            _radius = value;
        }
    }
    
    // Virtual properties that can be overridden by class inheritors.
    public virtual string Name => "Circle";
    public virtual double Area => Math.PI * Math.Pow(Radius, 2);

    // Constructor with a default value.
    public Circle(double radius = 5)
    {
        Radius = radius;
    }
}