namespace PolymorphismOOP.Models;

public class Rhombus : Square
{
    // Overriding properties that use their own return values.
    public override string Name => "Rhombus";

    /*
     * Constructor with a default value that performs a base call to its parent class and passes the local double to
     * its constructor.
     */
    public Rhombus(double side = 7) :base(side)
    {
    }
}