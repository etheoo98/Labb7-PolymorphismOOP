namespace PolymorphismOOP.Models;

public class Sphere : Circle
{
    public override string Name => "Sphere";
    public override double Area => 4 * Math.PI * Math.Pow(Radius, 2);

    /*
     * Constructor with a default value that performs a base call to its parent class and passes the local double to
     * its constructor. This is done because spheres also only use radii.
     */
    public Sphere(double radius = 8) : base(radius)
    {
    }
}