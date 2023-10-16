namespace PolymorphismOOP.Models;

public class Rhombus : Square
{
    public override string Name => "Rhombus";
    /*
     * Constructor with a default value that performs a base call to its parent class and passes the local double to
     * its constructor. This is done because rhombuses also only have one length, just like squares.
     */
    public Rhombus(double side = 7) :base(side)
    {
    }
}