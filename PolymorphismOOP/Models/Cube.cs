namespace PolymorphismOOP.Models;

public class Cube : Square
{
    // Overriding properties that use their own return values.
    public override string Name => "Cube";
    public override double Area => 6 * Math.Pow(Side, 2);

    /*
     * Constructor with a default value that performs a base call to its parent class and passes the local double to
     * its constructor.
     */
    public Cube(double side = 5) : base(side)
    {
    }
}