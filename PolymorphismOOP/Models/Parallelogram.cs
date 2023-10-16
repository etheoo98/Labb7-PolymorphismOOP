namespace PolymorphismOOP.Models;

public class Parallelogram : Rectangle
{
    // Overriding property that uses its own return value.
    public override string Name => "Parallelogram";

    /*
     * Constructor with default values that performs a base call to its parent class and passes the local doubles to
     * its constructor.
     */
    public Parallelogram(double width = 10, double height = 5) :base(width, height)
    {
    }
}