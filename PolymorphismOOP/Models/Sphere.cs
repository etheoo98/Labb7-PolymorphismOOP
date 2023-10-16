namespace PolymorphismOOP.Models;

public class Sphere : Circle
{
    // Overriding properties that use their own return values.
    public override string Name => "Sphere";
    public override double Area => 4 * Math.PI * Math.Pow(Radius, 2);

    /*
     * Constructor with a default value that performs a base call to its parent class and passes the local double to
     * its constructor.
     */
    public Sphere(double radius = 8) : base(radius)
    {
    }
}