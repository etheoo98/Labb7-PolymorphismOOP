namespace PolymorphismOOP.Models;

public class Cube : Square
{
    public override string Name => "Cube";
    public override double Area => 6 * Math.Pow(Side, 2);

    /*
     * Constructor with a default value that performs a base call to its parent class and passes the local double to
     * its constructor. This is done because cubes also only have one length, just like squares.
     */
    public Cube(double side = 5) : base(side)
    {
    }
}