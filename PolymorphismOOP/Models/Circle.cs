using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Circle : IGeometry
{
    public virtual string Name => "Circle";
    public virtual double Area => Math.PI * Math.Pow(Radius, 2);
    /*
     * We check the value of radius sent to the constructor, to ensure that it is a positive value, since radii
     * aren't expected to be zero or negative, before we assign the value to the _radius field. If it is not a positive
     * value an exception is thrown.
     */
    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to '_radius'");
            _radius = value;
        }
    }
    
    public Circle(double radius = 5)
    {
        Radius = radius;
    }
    
    private double _radius;
}